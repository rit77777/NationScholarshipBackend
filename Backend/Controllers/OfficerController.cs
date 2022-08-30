﻿using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using System;
using System.Linq;
using Backend.DTOs.Officer;
using System.Security.Claims;
using System.Collections.Generic;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficerController : Controller
    {
        private readonly ScholarshipDbContext _context;
        private readonly IConfiguration _configuration;

        public OfficerController(ScholarshipDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpPost("Login")]
        public ActionResult<string> Login([FromBody] OfficerLoginDto officerLoginDto)
        {
            try
            {
                var officerUser = _context.NodalOfficers
                    .Where(officer => officer.OfficerEmail == officerLoginDto.Email)
                    .FirstOrDefault();

                if (officerUser == null)
                {
                    return NotFound("User not found");
                }

                if (!VerifyPasswordHash(officerLoginDto.Password, officerUser.PasswordHash, officerUser.PasswordSalt))
                {
                    return BadRequest("Wrong password.");
                }

                string token = GenerateToken(officerUser);
                return Ok(new { Token = token });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }
        }

        private string GenerateToken(NodalOfficer officer)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, officer.OfficerEmail),
                new Claim(ClaimTypes.Role, "Officer")
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

        [HttpGet("PendingInstitutes")]
        [Authorize(Roles = "Officer")]
        public IActionResult GetInstitutes()
        {
            try
            {
                var pendingInstitutes = _context.Institutes
                    .Where(x => !x.ApprovedByOfficer)
                    .ToList();

                if (!pendingInstitutes.Any()) return NotFound( new { Message = "No application pending" });

                return Ok(pendingInstitutes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }
        }

        [HttpGet("PendingInstitutes/{id}")]
        [Authorize(Roles = "Officer")]
        public IActionResult GetInstitute(int id)
        {
            try
            {
                var pendingInstitute = _context.Institutes.Find(id);

                if (pendingInstitute == null) return NotFound("Institute not found");

                return Ok(pendingInstitute);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }
        }

        [HttpGet("PendingApplications")]
        [Authorize(Roles = "Officer")]
        public IActionResult GetApplications()
        {
            try
            {
                var pendingApplications = _context.ScholarshipApplications
                    .Where(x => !x.ApprovedByOfficer && x.ApprovedByInstitute)
                    .ToList();

                if (!pendingApplications.Any()) return BadRequest("Application not found");

                return Ok(pendingApplications);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }
        }

        [HttpGet("PendingApplications/{id}")]
        [Authorize(Roles = "Officer")]
        public IActionResult GetApplication(int id)
        {
            try
            {
                var application = _context.ScholarshipApplications.Find(id);

                if (application == null) return NotFound();

                return Ok(application);
            }
            catch(Exception ex) { 
                return BadRequest(ex.InnerException.Message);
            } 
        }

        [HttpPost("VerifyInstitute/{id}")]
        [Authorize(Roles = "Officer")]
        public IActionResult VerifyInstitute(int id)
        {
            try
            {
                var institute = _context.Institutes.Find(id);

                if (institute == null) return NotFound();

                if (institute.ApprovedByOfficer) return BadRequest("Already approved by officer");

                institute.ApprovedByOfficer = true;

                var result = _context.SaveChanges() > 0;

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("VerifyApplication/{id}")]
        [Authorize(Roles = "Officer")]
        public IActionResult VerifyApplication(int id)
        {
            try
            {
                var application = _context.ScholarshipApplications.Find(id);

                if (application == null) return NotFound();

                if (!application.ApprovedByInstitute) return BadRequest("Institute needs to approve before officer");

                if (application.ApprovedByOfficer) return BadRequest("Already approved by officer");

                application.ApprovedByOfficer = true;

                var result = _context.SaveChanges() > 0;

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("RejectApplication/{id}")]
        [Authorize(Roles = "Officer")]
        //reject the scholarship application
        public IActionResult RejectApplication(int id)
        {
            try
            {
                var application = _context.ScholarshipApplications
                    .Where(application => application.ApplicationId == id)
                    .FirstOrDefault();

                application.IsRejected = true;

                var result = _context.SaveChanges() > 0;

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("RejectInstitute/{id}")]
        [Authorize(Roles = "Officer")]
        //reject the scholarship application
        public IActionResult RejectInstitute(int id)
        {
            try
            {
                var institute = _context.Institutes
                    .Where(institute => institute.InstituteId == id)
                    .FirstOrDefault();

                institute.IsRejected = true;

                var result = _context.SaveChanges() > 0;

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private string GetOfficerEmail()
        {
            return User?.Identity?.Name;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }
    }
}

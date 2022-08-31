﻿// <auto-generated />
using System;
using Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Backend.Migrations
{
    [DbContext(typeof(ScholarshipDbContext))]
    [Migration("20220830112338_Changes")]
    partial class Changes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Backend.Models.Institute", b =>
                {
                    b.Property<int>("InstituteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressPincode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AffliatedUniversityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AffliatedUniversityState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ApprovedByMinistry")
                        .HasColumnType("bit");

                    b.Property<bool>("ApprovedByOfficer")
                        .HasColumnType("bit");

                    b.Property<string>("DiseCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstituteCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstituteCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("InstituteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstituteType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRejected")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PrincipalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationCertificate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniversityAffliationCertificate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearOfAddmission")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InstituteId");

                    b.HasIndex("DiseCode", "InstituteCode")
                        .IsUnique()
                        .HasFilter("[DiseCode] IS NOT NULL AND [InstituteCode] IS NOT NULL");

                    b.ToTable("Institutes");
                });

            modelBuilder.Entity("Backend.Models.Ministry", b =>
                {
                    b.Property<int>("MinistryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MinistryEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("MinistryId");

                    b.ToTable("Ministries");

                    b.HasData(
                        new
                        {
                            MinistryId = 1,
                            MinistryEmail = "ministry@nsp.com",
                            Name = "Ministry",
                            PasswordHash = new byte[] { 127, 42, 92, 197, 84, 202, 155, 66, 33, 205, 24, 7, 199, 43, 53, 186, 188, 236, 33, 13, 210, 125, 212, 216, 116, 125, 233, 132, 51, 31, 118, 54, 159, 29, 71, 131, 80, 110, 203, 118, 252, 27, 5, 120, 93, 144, 187, 89, 146, 162, 44, 69, 104, 219, 46, 185, 242, 28, 152, 49, 235, 67, 202, 55 },
                            PasswordSalt = new byte[] { 5, 85, 32, 215, 27, 205, 198, 108, 15, 14, 107, 109, 59, 24, 46, 219, 122, 187, 161, 233, 142, 255, 177, 185, 178, 169, 137, 147, 11, 163, 79, 168, 207, 28, 88, 104, 60, 155, 38, 32, 206, 54, 168, 243, 43, 253, 236, 24, 40, 251, 131, 116, 56, 94, 125, 157, 233, 151, 236, 81, 204, 123, 224, 146, 69, 9, 185, 222, 91, 84, 173, 7, 223, 62, 148, 200, 95, 7, 251, 95, 1, 72, 241, 61, 25, 232, 83, 91, 25, 77, 18, 163, 174, 185, 150, 220, 163, 191, 176, 178, 160, 47, 68, 169, 42, 153, 127, 184, 214, 74, 133, 59, 128, 153, 244, 155, 185, 227, 164, 4, 82, 31, 51, 101, 101, 227, 134, 54 }
                        });
                });

            modelBuilder.Entity("Backend.Models.NodalOfficer", b =>
                {
                    b.Property<int>("OfficerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OfficerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("OfficerId");

                    b.ToTable("NodalOfficers");

                    b.HasData(
                        new
                        {
                            OfficerId = 1,
                            OfficerEmail = "officer@nsp.com",
                            OfficerName = "Officer",
                            PasswordHash = new byte[] { 191, 26, 245, 111, 44, 128, 193, 240, 197, 59, 101, 105, 59, 171, 208, 62, 65, 137, 130, 75, 191, 62, 185, 210, 153, 8, 48, 90, 57, 167, 230, 3, 75, 235, 48, 225, 4, 250, 72, 6, 80, 40, 163, 49, 196, 94, 185, 139, 122, 130, 230, 191, 108, 91, 158, 189, 106, 111, 205, 8, 174, 159, 214, 104 },
                            PasswordSalt = new byte[] { 86, 190, 185, 192, 173, 198, 41, 18, 181, 40, 92, 152, 15, 236, 229, 52, 36, 46, 96, 230, 163, 223, 110, 45, 73, 239, 162, 109, 49, 204, 61, 47, 210, 164, 172, 129, 187, 88, 196, 29, 87, 137, 86, 242, 13, 102, 152, 76, 100, 72, 151, 108, 233, 174, 72, 125, 5, 101, 210, 8, 79, 183, 246, 96, 161, 15, 253, 174, 138, 97, 9, 143, 238, 45, 196, 151, 67, 18, 132, 64, 216, 159, 102, 184, 13, 134, 139, 147, 22, 59, 191, 157, 49, 45, 224, 137, 239, 213, 96, 119, 117, 161, 158, 21, 10, 6, 221, 185, 182, 161, 76, 89, 42, 85, 246, 67, 158, 165, 67, 39, 8, 72, 116, 91, 90, 22, 162, 55 }
                        });
                });

            modelBuilder.Entity("Backend.Models.ScholarshipApplication", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AadharCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AadharNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddmissionFee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnnualIncome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ApprovedByInstitute")
                        .HasColumnType("bit");

                    b.Property<bool>("ApprovedByMinistry")
                        .HasColumnType("bit");

                    b.Property<bool>("ApprovedByOfficer")
                        .HasColumnType("bit");

                    b.Property<string>("BankPassBook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Block")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoardName10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoardName12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CasteOrIncomeCertificate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CertificateUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassStartDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Community")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DomicileCertificate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeeReceiptOfCurrentYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstituteCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstituteIdCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstituteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsDisabled")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRejected")
                        .HasColumnType("bit");

                    b.Property<string>("MarkSheet10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarkSheet12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MartialStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModeOfStudy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherFee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentProfession")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassingYear10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassingYear12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Percentage10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Percentage12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PercentageDisability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pincode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PresentCourse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PresentCourseYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreviousClassPercentage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreviousCourse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreviousPassingYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreviousYearMarksheet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Religion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RollNo10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RollNo12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchemeId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("TutionFee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfDisability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniversityBoardName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApplicationId");

                    b.HasIndex("SchemeId");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("ScholarshipApplications");
                });

            modelBuilder.Entity("Backend.Models.ScholarshipScheme", b =>
                {
                    b.Property<int>("SchemeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SchemeId");

                    b.ToTable("ScholarshipSchemes");
                });

            modelBuilder.Entity("Backend.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AadharNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BankAccountNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BankIfscCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstituteCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InstituteId")
                        .HasColumnType("int");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StateOfDomicile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("InstituteId");

                    b.HasIndex("AadharNumber", "PhoneNo", "BankAccountNumber")
                        .IsUnique()
                        .HasFilter("[AadharNumber] IS NOT NULL AND [PhoneNo] IS NOT NULL AND [BankAccountNumber] IS NOT NULL");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Backend.Models.ScholarshipApplication", b =>
                {
                    b.HasOne("Backend.Models.ScholarshipScheme", "ScholarshipScheme")
                        .WithMany("ScholarshipApplication")
                        .HasForeignKey("SchemeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Models.Student", "Student")
                        .WithOne("ScholarshipApplication")
                        .HasForeignKey("Backend.Models.ScholarshipApplication", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ScholarshipScheme");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Backend.Models.Student", b =>
                {
                    b.HasOne("Backend.Models.Institute", "Institute")
                        .WithMany("Student")
                        .HasForeignKey("InstituteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Institute");
                });

            modelBuilder.Entity("Backend.Models.Institute", b =>
                {
                    b.Navigation("Student");
                });

            modelBuilder.Entity("Backend.Models.ScholarshipScheme", b =>
                {
                    b.Navigation("ScholarshipApplication");
                });

            modelBuilder.Entity("Backend.Models.Student", b =>
                {
                    b.Navigation("ScholarshipApplication");
                });
#pragma warning restore 612, 618
        }
    }
}
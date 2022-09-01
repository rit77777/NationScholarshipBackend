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
    [Migration("20220901165612_InitialCreate")]
    partial class InitialCreate
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

                    b.Property<int>("AddressPincode")
                        .HasColumnType("int");

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
                            PasswordHash = new byte[] { 196, 196, 210, 25, 134, 31, 198, 50, 197, 255, 26, 188, 159, 225, 152, 181, 224, 233, 57, 23, 192, 41, 240, 242, 154, 65, 46, 83, 93, 52, 160, 105, 108, 94, 231, 201, 158, 146, 219, 239, 130, 63, 194, 167, 210, 132, 79, 151, 249, 234, 207, 1, 173, 148, 110, 84, 149, 51, 175, 96, 153, 226, 239, 11 },
                            PasswordSalt = new byte[] { 195, 147, 239, 64, 216, 226, 202, 136, 81, 171, 239, 37, 47, 126, 141, 1, 7, 17, 122, 234, 7, 171, 35, 182, 38, 24, 190, 15, 124, 102, 157, 46, 165, 144, 84, 51, 103, 165, 30, 46, 55, 70, 200, 126, 126, 94, 242, 254, 122, 52, 78, 81, 140, 21, 84, 145, 68, 46, 219, 248, 96, 90, 193, 119, 74, 134, 174, 150, 47, 162, 65, 28, 187, 93, 164, 125, 172, 20, 144, 41, 180, 204, 248, 141, 164, 242, 172, 237, 64, 181, 181, 19, 90, 229, 251, 248, 207, 31, 126, 104, 18, 4, 194, 252, 122, 253, 9, 92, 101, 11, 244, 41, 143, 253, 198, 216, 198, 4, 143, 100, 81, 95, 8, 223, 51, 111, 210, 135 }
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
                            PasswordHash = new byte[] { 179, 46, 117, 229, 18, 228, 48, 91, 255, 75, 84, 163, 110, 93, 131, 5, 247, 12, 122, 239, 49, 86, 112, 169, 44, 108, 207, 59, 182, 153, 86, 252, 227, 78, 66, 71, 163, 255, 206, 185, 105, 188, 136, 184, 243, 174, 53, 74, 88, 0, 229, 156, 212, 248, 67, 54, 143, 155, 117, 204, 213, 61, 69, 244 },
                            PasswordSalt = new byte[] { 196, 113, 219, 23, 51, 234, 191, 34, 119, 205, 225, 69, 12, 2, 188, 182, 247, 1, 45, 56, 168, 96, 110, 216, 212, 204, 47, 121, 142, 161, 58, 140, 213, 31, 102, 0, 134, 65, 37, 229, 33, 69, 2, 103, 93, 83, 164, 200, 41, 197, 205, 100, 147, 173, 202, 211, 228, 175, 67, 247, 196, 222, 113, 246, 28, 112, 202, 182, 49, 205, 111, 188, 100, 49, 18, 69, 27, 240, 129, 2, 126, 75, 75, 63, 1, 131, 64, 159, 43, 89, 218, 115, 157, 126, 189, 184, 81, 52, 127, 153, 20, 152, 51, 214, 81, 81, 115, 250, 198, 14, 227, 137, 231, 187, 121, 55, 10, 191, 21, 95, 225, 158, 28, 73, 12, 98, 124, 175 }
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

                    b.Property<int>("AddmissionFee")
                        .HasColumnType("int");

                    b.Property<int>("AnnualIncome")
                        .HasColumnType("int");

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

                    b.Property<int>("OtherFee")
                        .HasColumnType("int");

                    b.Property<string>("ParentProfession")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PassingYear10")
                        .HasColumnType("int");

                    b.Property<int>("PassingYear12")
                        .HasColumnType("int");

                    b.Property<int>("Percentage10")
                        .HasColumnType("int");

                    b.Property<int>("Percentage12")
                        .HasColumnType("int");

                    b.Property<int>("PercentageDisability")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pincode")
                        .HasColumnType("int");

                    b.Property<string>("PresentCourse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PresentCourseYear")
                        .HasColumnType("int");

                    b.Property<int>("PreviousClassPercentage")
                        .HasColumnType("int");

                    b.Property<string>("PreviousCourse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PreviousPassingYear")
                        .HasColumnType("int");

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

                    b.Property<int>("TutionFee")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfDisability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniversityBoardName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApplicationId");

                    b.HasIndex("SchemeId");

                    b.HasIndex("StudentId");

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
                        .WithMany("ScholarshipApplication")
                        .HasForeignKey("StudentId")
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
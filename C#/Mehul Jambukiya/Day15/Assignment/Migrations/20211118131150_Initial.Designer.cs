﻿// <auto-generated />
using System;
using Day15_Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Day15_Assignment.Migrations
{
    [DbContext(typeof(EmployeeApiDbContext))]
    [Migration("20211118131150_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Day15_Assignment.Models.Assignment", b =>
                {
                    b.Property<long>("AssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActionCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActionReasonCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ActualTerminationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AssignmentCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssignmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssignmentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AssignmentProjectedEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AssignmentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("AssignmentStatusTypeId")
                        .HasColumnType("bigint");

                    b.Property<long>("BusinessUnitId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DefaultExpenseAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("DepartmentId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("EffectiveEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EffectiveStartDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("EmployeeRefId")
                        .HasColumnType("bigint");

                    b.Property<string>("EndTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Frequency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullPartTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("GradeId")
                        .HasColumnType("bigint");

                    b.Property<long>("GradeLadderId")
                        .HasColumnType("bigint");

                    b.Property<long>("JobId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("LegalEntityId")
                        .HasColumnType("bigint");

                    b.Property<long>("LocationId")
                        .HasColumnType("bigint");

                    b.Property<long>("ManagerAssignmentId")
                        .HasColumnType("bigint");

                    b.Property<long>("ManagerId")
                        .HasColumnType("bigint");

                    b.Property<bool>("isActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("AssignmentId");

                    b.HasIndex("EmployeeRefId");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("Day15_Assignment.Models.Employee", b =>
                {
                    b.Property<long>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CitizenshipId")
                        .HasColumnType("bigint");

                    b.Property<string>("CitizenshipLegislationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CitizenshipStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CitizenshipToDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorrespondenceLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DriversLicenseExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("DriversLicenseId")
                        .HasColumnType("bigint");

                    b.Property<string>("DriversLicenseIssuingCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EffectiveStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ethnicity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HomeFaxAreaCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeFaxCountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeFaxExtension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeFaxLegislationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeFaxNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePhoneAreaCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePhoneCountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePhoneExtension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePhoneLegislationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Honors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("LegalEntityId")
                        .HasColumnType("bigint");

                    b.Property<string>("LicenseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MilitaryVetStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSuffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalIdCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Day15_Assignment.Models.Assignment", b =>
                {
                    b.HasOne("Day15_Assignment.Models.Employee", "Employee")
                        .WithMany("assignments")
                        .HasForeignKey("EmployeeRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

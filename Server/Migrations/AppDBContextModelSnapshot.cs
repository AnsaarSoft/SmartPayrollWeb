﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Repository;

#nullable disable

namespace Server.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SharedLibrary.Models.Administration.MstCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CreatedBy")
                        .HasColumnOrder(500);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate")
                        .HasColumnOrder(502);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Subscription")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("UpdatedBy")
                        .HasColumnOrder(501);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate")
                        .HasColumnOrder(503);

                    b.Property<string>("cAppStamp")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("cAppStamp")
                        .HasColumnOrder(504);

                    b.Property<bool>("flgActive")
                        .HasColumnType("bit")
                        .HasColumnName("flgActive")
                        .HasColumnOrder(498);

                    b.Property<bool>("flgDelete")
                        .HasColumnType("bit")
                        .HasColumnName("flgDelete")
                        .HasColumnOrder(499);

                    b.Property<string>("uAppStamp")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("uAppStamp")
                        .HasColumnOrder(505);

                    b.HasKey("Id");

                    b.ToTable("MstCompany");
                });

            modelBuilder.Entity("SharedLibrary.Models.Administration.MstUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CreatedBy")
                        .HasColumnOrder(500);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate")
                        .HasColumnOrder(502);

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UnitSize")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("UpdatedBy")
                        .HasColumnOrder(501);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate")
                        .HasColumnOrder(503);

                    b.Property<string>("cAppStamp")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("cAppStamp")
                        .HasColumnOrder(504);

                    b.Property<bool>("flgActive")
                        .HasColumnType("bit")
                        .HasColumnName("flgActive")
                        .HasColumnOrder(498);

                    b.Property<bool>("flgDelete")
                        .HasColumnType("bit")
                        .HasColumnName("flgDelete")
                        .HasColumnOrder(499);

                    b.Property<string>("uAppStamp")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("uAppStamp")
                        .HasColumnOrder(505);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("MstUnit");
                });

            modelBuilder.Entity("SharedLibrary.Models.Employee.MstEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("ConfirmationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CreatedBy")
                        .HasColumnOrder(500);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate")
                        .HasColumnOrder(502);

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("ServiceEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ServiceStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("UpdatedBy")
                        .HasColumnOrder(501);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate")
                        .HasColumnOrder(503);

                    b.Property<string>("UserCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("UserType")
                        .HasColumnType("bit");

                    b.Property<string>("WorkAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cAppStamp")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("cAppStamp")
                        .HasColumnOrder(504);

                    b.Property<bool>("flgActive")
                        .HasColumnType("bit")
                        .HasColumnName("flgActive")
                        .HasColumnOrder(498);

                    b.Property<bool>("flgDelete")
                        .HasColumnType("bit")
                        .HasColumnName("flgDelete")
                        .HasColumnOrder(499);

                    b.Property<string>("uAppStamp")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("uAppStamp")
                        .HasColumnOrder(505);

                    b.HasKey("Id");

                    b.ToTable("MstEmployees");
                });

            modelBuilder.Entity("SharedLibrary.Models.Employee.MstUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CreatedBy")
                        .HasColumnOrder(500);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate")
                        .HasColumnOrder(502);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Email")
                        .HasColumnOrder(4);

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Password")
                        .HasColumnOrder(3);

                    b.Property<int?>("UnitId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("UpdatedBy")
                        .HasColumnOrder(501);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate")
                        .HasColumnOrder(503);

                    b.Property<string>("UserCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("UserCode")
                        .HasColumnOrder(2);

                    b.Property<int>("UserType")
                        .HasColumnType("int")
                        .HasColumnName("UserType")
                        .HasColumnOrder(5);

                    b.Property<string>("cAppStamp")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("cAppStamp")
                        .HasColumnOrder(504);

                    b.Property<bool>("flgActive")
                        .HasColumnType("bit")
                        .HasColumnName("flgActive")
                        .HasColumnOrder(498);

                    b.Property<bool>("flgDelete")
                        .HasColumnType("bit")
                        .HasColumnName("flgDelete")
                        .HasColumnOrder(499);

                    b.Property<string>("uAppStamp")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("uAppStamp")
                        .HasColumnOrder(505);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("UnitId");

                    b.ToTable("MstUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Auto",
                            CreatedDate = new DateTime(2024, 2, 8, 13, 28, 39, 89, DateTimeKind.Local).AddTicks(4324),
                            Email = "",
                            Password = "super@123",
                            UpdatedBy = "Auto",
                            UpdatedDate = new DateTime(2024, 2, 8, 13, 28, 39, 89, DateTimeKind.Local).AddTicks(4335),
                            UserCode = "manager",
                            UserType = 1,
                            cAppStamp = "Auto",
                            flgActive = true,
                            flgDelete = false,
                            uAppStamp = "Auto"
                        });
                });

            modelBuilder.Entity("SharedLibrary.Models.Administration.MstUnit", b =>
                {
                    b.HasOne("SharedLibrary.Models.Administration.MstCompany", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("SharedLibrary.Models.Employee.MstUser", b =>
                {
                    b.HasOne("SharedLibrary.Models.Administration.MstCompany", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("SharedLibrary.Models.Employee.MstEmployee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("SharedLibrary.Models.Administration.MstUnit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId");

                    b.Navigation("Company");

                    b.Navigation("Employee");

                    b.Navigation("Unit");
                });
#pragma warning restore 612, 618
        }
    }
}

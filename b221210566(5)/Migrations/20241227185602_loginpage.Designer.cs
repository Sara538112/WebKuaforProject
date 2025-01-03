﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using b221210566_5_.Data;

#nullable disable

namespace b221210566_5_.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241227185602_loginpage")]
    partial class loginpage
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "4c4d19a4-030b-4b5f-9713-d7fb7d5f9862",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "f9708ff2-b2fd-488c-89a7-d19c28d6a91a",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = "596aa8cf-7c3b-45c1-974b-4aae48dc7477",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "a3de0de7-515b-4ade-be45-85054fcaa040",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "943473f4-2aad-45ca-8041-40874d3a42b8",
                            RoleId = "4c4d19a4-030b-4b5f-9713-d7fb7d5f9862"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("b221210566_5_.Models.AppointmentEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AppointmentId")
                        .HasColumnType("integer");

                    b.Property<string>("AvaliableTime")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("appointmentEmployees");
                });

            modelBuilder.Entity("b221210566_5_.Models.Appointments", b =>
                {
                    b.Property<int>("AppNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AppNo"));

                    b.Property<bool>("Approved")
                        .HasColumnType("boolean");

                    b.Property<string>("CustomerId")
                        .HasColumnType("text");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<float>("Period")
                        .HasColumnType("real");

                    b.Property<TimeOnly>("Time")
                        .HasColumnType("time without time zone");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<float>("coast")
                        .HasColumnType("real");

                    b.HasKey("AppNo");

                    b.HasIndex("CustomerId");

                    b.HasIndex("UserId");

                    b.ToTable("appointments");
                });

            modelBuilder.Entity("b221210566_5_.Models.DTOs.UserRegisterDTO", b =>
                {
                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Department")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.ToTable("UserRegisterDTOs");
                });

            modelBuilder.Entity("b221210566_5_.Models.DepEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("DepEmployees");
                });

            modelBuilder.Entity("b221210566_5_.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hair Cut"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Hair Care"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hair Dye"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Manikur"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Padikur"
                        });
                });

            modelBuilder.Entity("b221210566_5_.Models.EmployeeManager", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("EmployeeID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ManagerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("EmployeeID")
                        .IsUnique();

                    b.HasIndex("ManagerId");

                    b.ToTable("EmployeeManager");
                });

            modelBuilder.Entity("b221210566_5_.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator().HasValue("User");

                    b.UseTphMappingStrategy();

                    b.HasData(
                        new
                        {
                            Id = "943473f4-2aad-45ca-8041-40874d3a42b8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "31fd7724-22c5-4ba2-9a1f-f01d26723803",
                            Email = "b221210566@ogr.sakarya.edu.tr",
                            EmailConfirmed = true,
                            FirstName = "Sara",
                            LastName = "Mohamed",
                            LockoutEnabled = false,
                            NormalizedEmail = "B221210566@OGR.SAKARYA.EDU.TR",
                            PasswordHash = "AQAAAAIAAYagAAAAENOgmtXmRNGrxPHlme0TbKWy60cb6J13JPhhSR0lM4xB+I4s4tOu9uIF1rXjk5Xyuw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0c4e6c62-eced-4bfb-b9f4-513cd84db4dd",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("b221210566_5_.Models.Employee", b =>
                {
                    b.HasBaseType("b221210566_5_.Models.User");

                    b.HasDiscriminator().HasValue("Employee");
                });

            modelBuilder.Entity("b221210566_5_.Models.Manager", b =>
                {
                    b.HasBaseType("b221210566_5_.Models.User");

                    b.HasDiscriminator().HasValue("Manager");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("b221210566_5_.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("b221210566_5_.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("b221210566_5_.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("b221210566_5_.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("b221210566_5_.Models.AppointmentEmployee", b =>
                {
                    b.HasOne("b221210566_5_.Models.Appointments", "Appointment")
                        .WithMany("AppointmentEmployees")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("b221210566_5_.Models.Employee", "Employee")
                        .WithMany("AppointmentEmployees")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("b221210566_5_.Models.Appointments", b =>
                {
                    b.HasOne("b221210566_5_.Models.User", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("b221210566_5_.Models.User", null)
                        .WithMany("Appointments")
                        .HasForeignKey("UserId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("b221210566_5_.Models.DepEmployee", b =>
                {
                    b.HasOne("b221210566_5_.Models.Department", "Department")
                        .WithMany("DepEmployees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("b221210566_5_.Models.Employee", "Employee")
                        .WithOne("DepEmployees")
                        .HasForeignKey("b221210566_5_.Models.DepEmployee", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("b221210566_5_.Models.EmployeeManager", b =>
                {
                    b.HasOne("b221210566_5_.Models.Employee", "Employees")
                        .WithOne("EmployeeManager")
                        .HasForeignKey("b221210566_5_.Models.EmployeeManager", "EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("b221210566_5_.Models.Manager", "Managers")
                        .WithMany("EmployeeManager")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");

                    b.Navigation("Managers");
                });

            modelBuilder.Entity("b221210566_5_.Models.Appointments", b =>
                {
                    b.Navigation("AppointmentEmployees");
                });

            modelBuilder.Entity("b221210566_5_.Models.Department", b =>
                {
                    b.Navigation("DepEmployees");
                });

            modelBuilder.Entity("b221210566_5_.Models.User", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("b221210566_5_.Models.Employee", b =>
                {
                    b.Navigation("AppointmentEmployees");

                    b.Navigation("DepEmployees")
                        .IsRequired();

                    b.Navigation("EmployeeManager")
                        .IsRequired();
                });

            modelBuilder.Entity("b221210566_5_.Models.Manager", b =>
                {
                    b.Navigation("EmployeeManager");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using EmployeeManager.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EmployeeManager.Infrastructure.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20210908131600_ChangedTeamIdColumn")]
    partial class ChangedTeamIdColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("EmployeeManager.API.Entities.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("client_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("BusinessName")
                        .HasColumnType("text")
                        .HasColumnName("business_name");

                    b.Property<string>("ContactName")
                        .HasColumnType("text")
                        .HasColumnName("contact_name");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("HomeAddress")
                        .HasColumnType("text")
                        .HasColumnName("home_address");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("bytea")
                        .HasColumnName("picture");

                    b.Property<int>("ProjectID")
                        .HasColumnType("integer")
                        .HasColumnName("project_id");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<string>("ZipCity")
                        .HasColumnType("text")
                        .HasColumnName("zip_city");

                    b.HasKey("ClientID");

                    b.ToTable("clients");
                });

            modelBuilder.Entity("EmployeeManager.API.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("employee_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("begin_date");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("birth_date");

                    b.Property<float>("ContractedSalary")
                        .HasColumnType("real")
                        .HasColumnName("contracted_salary");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("end_date");

                    b.Property<string>("FirstName")
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("JobTitle")
                        .HasColumnType("text")
                        .HasColumnName("job_title");

                    b.Property<string>("LastName")
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("bytea")
                        .HasColumnName("picture");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.HasKey("EmployeeID");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("EmployeeManager.API.Entities.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("project_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("begin_date");

                    b.Property<int>("ClientID")
                        .HasColumnType("integer")
                        .HasColumnName("client_id");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("end_date");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<decimal>("PricingValue")
                        .HasColumnType("numeric")
                        .HasColumnName("pricing_value");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("text")
                        .HasColumnName("short_description");

                    b.Property<string>("Status")
                        .HasColumnType("text")
                        .HasColumnName("status");

                    b.Property<int>("TeamID")
                        .HasColumnType("integer")
                        .HasColumnName("team_id");

                    b.HasKey("ProjectID");

                    b.HasIndex("ClientID");

                    b.HasIndex("TeamID");

                    b.ToTable("projects");
                });

            modelBuilder.Entity("EmployeeManager.API.Entities.Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("team_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<float>("Amount")
                        .HasColumnType("real")
                        .HasColumnName("amount");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("integer")
                        .HasColumnName("employee_id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("team_name");

                    b.Property<string>("Pricing")
                        .HasColumnType("text")
                        .HasColumnName("pricing");

                    b.Property<string>("Role")
                        .HasColumnType("text")
                        .HasColumnName("role");

                    b.Property<string>("Status")
                        .HasColumnType("text")
                        .HasColumnName("status");

                    b.Property<string>("TeamIdentity")
                        .HasColumnType("text")
                        .HasColumnName("team_identity");

                    b.Property<int>("WeeklyEngagement")
                        .HasColumnType("integer")
                        .HasColumnName("weekly_engagement");

                    b.HasKey("TeamID");

                    b.ToTable("teams");
                });

            modelBuilder.Entity("EmployeeManager.API.Entities.TeamRoles", b =>
                {
                    b.Property<int>("TeamRolesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("team_roles_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("RoleName")
                        .HasColumnType("text")
                        .HasColumnName("role_name");

                    b.HasKey("TeamRolesID");

                    b.ToTable("team_roles");
                });

            modelBuilder.Entity("EmployeeManager.Core.Entities.ContactUsMessage", b =>
                {
                    b.Property<int>("ContactUsMessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("YourEmail")
                        .HasColumnType("text");

                    b.Property<string>("YourMessage")
                        .HasColumnType("text");

                    b.Property<string>("YourName")
                        .HasColumnType("text");

                    b.Property<string>("YourPhone")
                        .HasColumnType("text");

                    b.HasKey("ContactUsMessageID");

                    b.ToTable("ContactUsMessage");
                });

            modelBuilder.Entity("EmployeeManager.Core.Entities.EmployeeTeamRole", b =>
                {
                    b.Property<int>("EmployeeTeamRoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("employee_team_role_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("integer")
                        .HasColumnName("employee_id");

                    b.Property<int>("RoleID")
                        .HasColumnType("integer")
                        .HasColumnName("role_id");

                    b.Property<int>("TeamID")
                        .HasColumnType("integer")
                        .HasColumnName("team_id");

                    b.Property<int?>("TeamRolesID")
                        .HasColumnType("integer");

                    b.HasKey("EmployeeTeamRoleID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("TeamID");

                    b.HasIndex("TeamRolesID");

                    b.ToTable("employee_team_roles");
                });

            modelBuilder.Entity("EmployeeManager.API.Entities.Project", b =>
                {
                    b.HasOne("EmployeeManager.API.Entities.Client", "Client")
                        .WithMany("Project")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeeManager.API.Entities.Team", "Team")
                        .WithMany("Projects")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("EmployeeManager.Core.Entities.EmployeeTeamRole", b =>
                {
                    b.HasOne("EmployeeManager.API.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeeManager.API.Entities.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeeManager.API.Entities.TeamRoles", "TeamRoles")
                        .WithMany()
                        .HasForeignKey("TeamRolesID");

                    b.Navigation("Employee");

                    b.Navigation("Team");

                    b.Navigation("TeamRoles");
                });

            modelBuilder.Entity("EmployeeManager.API.Entities.Client", b =>
                {
                    b.Navigation("Project");
                });

            modelBuilder.Entity("EmployeeManager.API.Entities.Team", b =>
                {
                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}

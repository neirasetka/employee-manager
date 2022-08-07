using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EmployeeManager.Infrastructure.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    client_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    business_name = table.Column<string>(type: "text", nullable: true),
                    contact_name = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    project_id = table.Column<int>(type: "integer", nullable: false),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    phone_number = table.Column<string>(type: "text", nullable: true),
                    zip_city = table.Column<string>(type: "text", nullable: true),
                    picture = table.Column<byte[]>(type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.client_id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUsMessage",
                columns: table => new
                {
                    ContactUsMessageID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    YourName = table.Column<string>(type: "text", nullable: true),
                    YourEmail = table.Column<string>(type: "text", nullable: true),
                    YourPhone = table.Column<string>(type: "text", nullable: true),
                    YourMessage = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsMessage", x => x.ContactUsMessageID);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    employee_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(type: "text", nullable: true),
                    last_name = table.Column<string>(type: "text", nullable: true),
                    job_title = table.Column<string>(type: "text", nullable: true),
                    contracted_salary = table.Column<float>(type: "real", nullable: false),
                    picture = table.Column<byte[]>(type: "bytea", nullable: true),
                    begin_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    end_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    birth_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    phone_number = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.employee_id);
                });

            migrationBuilder.CreateTable(
                name: "team_roles",
                columns: table => new
                {
                    team_roles_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    role_name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_team_roles", x => x.team_roles_id);
                });

            migrationBuilder.CreateTable(
                name: "teams",
                columns: table => new
                {
                    project_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    team_identity = table.Column<string>(type: "text", nullable: true),
                    employee_id = table.Column<int>(type: "integer", nullable: false),
                    role = table.Column<string>(type: "text", nullable: true),
                    weekly_engagement = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<string>(type: "text", nullable: true),
                    pricing = table.Column<string>(type: "text", nullable: true),
                    amount = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teams", x => x.project_id);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    project_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    client = table.Column<string>(type: "text", nullable: true),
                    team = table.Column<string>(type: "text", nullable: true),
                    short_description = table.Column<string>(type: "text", nullable: true),
                    billing_amount = table.Column<float>(type: "real", nullable: false),
                    client_id = table.Column<int>(type: "integer", nullable: false),
                    pricing_type = table.Column<int>(type: "integer", nullable: false),
                    pricing_value = table.Column<decimal>(type: "numeric", nullable: false),
                    project_status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.project_id);
                    table.ForeignKey(
                        name: "FK_projects_clients_client_id",
                        column: x => x.client_id,
                        principalTable: "clients",
                        principalColumn: "client_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employee_team_roles",
                columns: table => new
                {
                    employee_team_role_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    employee_id = table.Column<int>(type: "integer", nullable: false),
                    team_id = table.Column<int>(type: "integer", nullable: false),
                    role_id = table.Column<int>(type: "integer", nullable: false),
                    TeamRolesID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_team_roles", x => x.employee_team_role_id);
                    table.ForeignKey(
                        name: "FK_employee_team_roles_employees_employee_id",
                        column: x => x.employee_id,
                        principalTable: "employees",
                        principalColumn: "employee_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employee_team_roles_team_roles_TeamRolesID",
                        column: x => x.TeamRolesID,
                        principalTable: "team_roles",
                        principalColumn: "team_roles_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employee_team_roles_teams_team_id",
                        column: x => x.team_id,
                        principalTable: "teams",
                        principalColumn: "project_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employee_team_roles_employee_id",
                table: "employee_team_roles",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_employee_team_roles_team_id",
                table: "employee_team_roles",
                column: "team_id");

            migrationBuilder.CreateIndex(
                name: "IX_employee_team_roles_TeamRolesID",
                table: "employee_team_roles",
                column: "TeamRolesID");

            migrationBuilder.CreateIndex(
                name: "IX_projects_client_id",
                table: "projects",
                column: "client_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactUsMessage");

            migrationBuilder.DropTable(
                name: "employee_team_roles");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "team_roles");

            migrationBuilder.DropTable(
                name: "teams");

            migrationBuilder.DropTable(
                name: "clients");
        }
    }
}

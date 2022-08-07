using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManager.Infrastructure.Migrations
{
    public partial class ChangesInTheTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "is_deleted",
                table: "employee_team_roles",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "role_in_the_team",
                table: "employee_team_roles",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "working_hours",
                table: "employee_team_roles",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_deleted",
                table: "employee_team_roles");

            migrationBuilder.DropColumn(
                name: "role_in_the_team",
                table: "employee_team_roles");

            migrationBuilder.DropColumn(
                name: "working_hours",
                table: "employee_team_roles");
        }
    }
}

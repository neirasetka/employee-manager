using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManager.Infrastructure.Migrations
{
    public partial class teamTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pricing",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "role",
                table: "teams");

            migrationBuilder.RenameColumn(
                name: "team_identity",
                table: "teams",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "teams",
                newName: "project_id");

            migrationBuilder.AlterColumn<int>(
                name: "amount",
                table: "teams",
                type: "integer",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "employees_team_id",
                table: "teams",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "is_deleted",
                table: "teams",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "employees_team_id",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "is_deleted",
                table: "teams");

            migrationBuilder.RenameColumn(
                name: "project_id",
                table: "teams",
                newName: "employee_id");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "teams",
                newName: "team_identity");

            migrationBuilder.AlterColumn<float>(
                name: "amount",
                table: "teams",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "pricing",
                table: "teams",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "role",
                table: "teams",
                type: "text",
                nullable: true);
        }
    }
}

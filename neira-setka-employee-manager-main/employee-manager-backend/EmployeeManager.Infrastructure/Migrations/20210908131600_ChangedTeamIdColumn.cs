using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManager.Infrastructure.Migrations
{
    public partial class ChangedTeamIdColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "project_id",
                table: "teams",
                newName: "team_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "team_id",
                table: "teams",
                newName: "project_id");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManager.Infrastructure.Migrations
{
    public partial class AddedTeamFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_projects_team_id",
                table: "projects",
                column: "team_id");

            migrationBuilder.AddForeignKey(
                name: "FK_projects_teams_team_id",
                table: "projects",
                column: "team_id",
                principalTable: "teams",
                principalColumn: "project_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_projects_teams_team_id",
                table: "projects");

            migrationBuilder.DropIndex(
                name: "IX_projects_team_id",
                table: "projects");
        }
    }
}

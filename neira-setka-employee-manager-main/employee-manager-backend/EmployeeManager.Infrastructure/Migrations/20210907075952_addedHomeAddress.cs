using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManager.Infrastructure.Migrations
{
    public partial class addedHomeAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "home_address",
                table: "clients",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "home_address",
                table: "clients");
        }
    }
}

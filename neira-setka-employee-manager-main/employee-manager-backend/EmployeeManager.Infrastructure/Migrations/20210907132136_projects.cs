using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManager.Infrastructure.Migrations
{
    public partial class projects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "billing_amount",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "pricing_type",
                table: "projects");

            migrationBuilder.RenameColumn(
                name: "team",
                table: "projects",
                newName: "team_name");

            migrationBuilder.RenameColumn(
                name: "project_status",
                table: "projects",
                newName: "team_id");

            migrationBuilder.RenameColumn(
                name: "client",
                table: "projects",
                newName: "status");

            migrationBuilder.AddColumn<DateTime>(
                name: "begin_date",
                table: "projects",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "client_name",
                table: "projects",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "end_date",
                table: "projects",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "begin_date",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "client_name",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "end_date",
                table: "projects");

            migrationBuilder.RenameColumn(
                name: "team_name",
                table: "projects",
                newName: "team");

            migrationBuilder.RenameColumn(
                name: "team_id",
                table: "projects",
                newName: "project_status");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "projects",
                newName: "client");

            migrationBuilder.AddColumn<float>(
                name: "billing_amount",
                table: "projects",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "pricing_type",
                table: "projects",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}

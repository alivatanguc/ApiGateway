using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DbConnection.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Reservations");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimer",
                table: "Reservations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTimer",
                table: "Reservations");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Reservations",
                type: "timestamp without time zone",
                nullable: true);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eria_back.Migrations
{
    public partial class DateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "CompanyEvents");

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeFrom",
                table: "CompanyEvents",
                type: "datetime2",
                nullable: true,
                defaultValue: null);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeTo",
                table: "CompanyEvents",
                type: "datetime2",
                nullable: true,
                defaultValue: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeFrom",
                table: "CompanyEvents");

            migrationBuilder.DropColumn(
                name: "TimeTo",
                table: "CompanyEvents");

            migrationBuilder.AddColumn<decimal>(
                name: "Time",
                table: "CompanyEvents",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}

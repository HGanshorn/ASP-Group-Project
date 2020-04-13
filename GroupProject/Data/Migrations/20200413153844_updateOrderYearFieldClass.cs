using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GroupProject.Data.Migrations
{
    public partial class updateOrderYearFieldClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Year",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "Orders",
                nullable: false,
                defaultValue: 0);
        }
    }
}

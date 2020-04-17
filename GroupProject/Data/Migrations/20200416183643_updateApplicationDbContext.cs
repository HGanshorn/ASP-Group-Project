using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GroupProject.Data.Migrations
{
    public partial class updateApplicationDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CategoryId1",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));


            /**************************************************************
             * 
             * Note from Glenn I think that this line was trying to add string 
             * CategoryId I think this line was causing the update-database to fail
             * 
             ***************************************************************
             */
             
            //migrationBuilder.AddColumn<string>(
            //    name: "CategoryId",
            //    table: "Products",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId1",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}

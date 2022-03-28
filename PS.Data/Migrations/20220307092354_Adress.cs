using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class Adress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Providers");

            migrationBuilder.RenameColumn(
                name: "StreetAdress",
                table: "Products",
                newName: "Myadress_StreetAdress");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Products",
                newName: "Myadress_City");

            migrationBuilder.AddColumn<string>(
                name: "Myadress_LabName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Myadress_LabName",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Myadress_StreetAdress",
                table: "Products",
                newName: "StreetAdress");

            migrationBuilder.RenameColumn(
                name: "Myadress_City",
                table: "Products",
                newName: "City");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Providers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

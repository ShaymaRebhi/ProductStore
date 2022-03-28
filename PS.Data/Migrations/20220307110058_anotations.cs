using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class anotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Providers_providersId",
                table: "ProductProvider");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "confirmPassword",
                table: "Providers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Providers",
                newName: "ProviderCode");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Products",
                newName: "CategoryFK");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryFK");

            migrationBuilder.RenameColumn(
                name: "providersId",
                table: "ProductProvider",
                newName: "providersProviderCode");

            migrationBuilder.RenameIndex(
                name: "IX_ProductProvider_providersId",
                table: "ProductProvider",
                newName: "IX_ProductProvider_providersProviderCode");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Providers_providersProviderCode",
                table: "ProductProvider",
                column: "providersProviderCode",
                principalTable: "Providers",
                principalColumn: "ProviderCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryFK",
                table: "Products",
                column: "CategoryFK",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Providers_providersProviderCode",
                table: "ProductProvider");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryFK",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ProviderCode",
                table: "Providers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CategoryFK",
                table: "Products",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryFK",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.RenameColumn(
                name: "providersProviderCode",
                table: "ProductProvider",
                newName: "providersId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductProvider_providersProviderCode",
                table: "ProductProvider",
                newName: "IX_ProductProvider_providersId");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "confirmPassword",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Providers_providersId",
                table: "ProductProvider",
                column: "providersId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

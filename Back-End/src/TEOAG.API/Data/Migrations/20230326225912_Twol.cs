using Microsoft.EntityFrameworkCore.Migrations;

namespace TEOAG.API.Data.Migrations
{
    public partial class Twol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "SupplierDescription");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "ProductName");

            migrationBuilder.AddColumn<string>(
                name: "CNPJSupplier",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExpirationDate",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufacturingDate",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductDescription",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CNPJSupplier",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ExpirationDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ManufacturingDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductDescription",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "SupplierDescription",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Products",
                newName: "Description");
        }
    }
}

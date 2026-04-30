using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StorageSystemBuildingMaterials.Migrations
{
    /// <inheritdoc />
    public partial class AddProductDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ReceivedDate",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ShelfLifeDays",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceivedDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ShelfLifeDays",
                table: "Products");
        }
    }
}

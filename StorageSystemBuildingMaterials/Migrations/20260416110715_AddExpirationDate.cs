using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StorageSystemBuildingMaterials.Migrations
{
    /// <inheritdoc />
    public partial class AddExpirationDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShelfLifeDays",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ReceivedDate",
                table: "Products",
                newName: "ExpirationDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpirationDate",
                table: "Products",
                newName: "ReceivedDate");

            migrationBuilder.AddColumn<int>(
                name: "ShelfLifeDays",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}

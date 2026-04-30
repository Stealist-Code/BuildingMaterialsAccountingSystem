using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StorageSystemBuildingMaterials.Migrations
{
    /// <inheritdoc />
    public partial class AddIsSupplyToShipment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSupply",
                table: "Shipments",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSupply",
                table: "Shipments");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StorageSystemBuildingMaterials.Migrations
{
    /// <inheritdoc />
    public partial class Init2105 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRateOnDayPurchace",
                table: "SupplyItems",
                type: "numeric(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PurchasePriceOnDayPurchace",
                table: "SupplyItems",
                type: "numeric(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExchangeRateOnDayPurchace",
                table: "SupplyItems");

            migrationBuilder.DropColumn(
                name: "PurchasePriceOnDayPurchace",
                table: "SupplyItems");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StorageSystemBuildingMaterials.Migrations
{
    /// <inheritdoc />
    public partial class AddDiscount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProductStateId",
                table: "SupplyItems",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "StateRules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DaysBeforeDiscount = table.Column<int>(type: "integer", nullable: false),
                    Discount = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateRules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductStates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StateRuleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductStates_StateRules_StateRuleId",
                        column: x => x.StateRuleId,
                        principalTable: "StateRules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplyItems_ProductStateId",
                table: "SupplyItems",
                column: "ProductStateId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStates_StateRuleId",
                table: "ProductStates",
                column: "StateRuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyItems_ProductStates_ProductStateId",
                table: "SupplyItems",
                column: "ProductStateId",
                principalTable: "ProductStates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplyItems_ProductStates_ProductStateId",
                table: "SupplyItems");

            migrationBuilder.DropTable(
                name: "ProductStates");

            migrationBuilder.DropTable(
                name: "StateRules");

            migrationBuilder.DropIndex(
                name: "IX_SupplyItems_ProductStateId",
                table: "SupplyItems");

            migrationBuilder.DropColumn(
                name: "ProductStateId",
                table: "SupplyItems");
        }
    }
}

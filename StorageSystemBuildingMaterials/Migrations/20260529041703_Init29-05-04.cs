using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StorageSystemBuildingMaterials.Migrations
{
    /// <inheritdoc />
    public partial class Init290504 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConfigurationApps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Language = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false, defaultValue: "ru")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationApps", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfigurationApps");
        }
    }
}

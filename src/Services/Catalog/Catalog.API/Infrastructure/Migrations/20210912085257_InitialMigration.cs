using Microsoft.EntityFrameworkCore.Migrations;

namespace Microsoft.tonisgarden.Services.Catalog.API.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "catalog_size_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "catalog_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "catalog_type_hilo",
                incrementBy: 10);

            migrationBuilder.CreateTable(
                name: "CatalogSize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogSize", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(4,2)", precision: 4, scale: 2, nullable: false),
                    PictureFileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatalogTypeId = table.Column<int>(type: "int", nullable: false),
                    CatalogSizeId = table.Column<int>(type: "int", nullable: false),
                    AvailableStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogItem_CatalogSize_CatalogSizeId",
                        column: x => x.CatalogSizeId,
                        principalTable: "CatalogSize",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatalogItem_CatalogType_CatalogTypeId",
                        column: x => x.CatalogTypeId,
                        principalTable: "CatalogType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CatalogSize",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Small" },
                    { 2, "Medium" },
                    { 3, "Large" }
                });

            migrationBuilder.InsertData(
                table: "CatalogType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Indoor Plants" },
                    { 2, "Outdoor Plants" }
                });

            migrationBuilder.InsertData(
                table: "CatalogItem",
                columns: new[] { "Id", "AvailableStock", "CatalogSizeId", "CatalogTypeId", "Name", "PictureFileName", "Price" },
                values: new object[,]
                {
                    { 18, 100, 1, 1, "Peperomia Watermelon", "21.png", 49m },
                    { 19, 100, 1, 1, "Ficus Altissima", "22.png", 99m },
                    { 20, 100, 1, 1, "Ponytail Palm", "23.png", 29m },
                    { 21, 100, 1, 1, "Hoya Macrophylla", "24.png", 49m },
                    { 22, 100, 1, 1, "Peace Lily", "25.png", 99m },
                    { 23, 100, 1, 1, "Bamboo Palm", "26.png", 99m },
                    { 24, 100, 1, 1, "Money Tree", "27.png", 99m },
                    { 25, 100, 3, 1, "Red Prayer Plant", "28.png", 39m },
                    { 26, 100, 3, 1, "Dracaena Rikki Cane", "29.png", 99m },
                    { 27, 100, 2, 1, "Silver Pothos", "30.png", 49m },
                    { 28, 100, 2, 1, "Calathea Collection", "31.png", 79m },
                    { 29, 100, 1, 2, "Purple African Violet", "32.png", 49m },
                    { 30, 100, 1, 2, "Dieffenbachia", "33.png", 99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatalogItem_CatalogSizeId",
                table: "CatalogItem",
                column: "CatalogSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogItem_CatalogTypeId",
                table: "CatalogItem",
                column: "CatalogTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatalogItem");

            migrationBuilder.DropTable(
                name: "CatalogSize");

            migrationBuilder.DropTable(
                name: "CatalogType");

            migrationBuilder.DropSequence(
                name: "catalog_size_hilo");

            migrationBuilder.DropSequence(
                name: "catalog_hilo");

            migrationBuilder.DropSequence(
                name: "catalog_type_hilo");
        }
    }
}

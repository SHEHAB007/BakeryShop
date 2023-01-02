using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BakeryShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class creatDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: true),
                    ProductDescription = table.Column<string>(type: "TEXT", nullable: true),
                    ProductPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImageName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ImageName", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, "Bread.jpeg", "Normal Bread", "Bread", 0m },
                    { 2, "BrownBread.jpeg", "Brown Fresh Bread", "Brown Bread", 0m },
                    { 3, "Corwasant.jpeg", "Fresh Corwasant", "Corwasant", 0m },
                    { 4, "CupCakes.jpeg", "Fresh CupCakes", "CupCakes", 0m },
                    { 5, "DarkTost.jpeg", "Fresh DarkTost", "DarkTost", 0m },
                    { 6, "FrenchBread.jpeg", "Fresh FrenchBread", "FrenchBread", 0m },
                    { 7, "ItalianBread.jpeg", "Fresh ItalianBread", "ItalianBread", 0m },
                    { 8, "Sandwiches.jpeg", "Fresh Sweet Sandwiches", "Sandwiches", 0m },
                    { 9, "WhiteTost.jpeg", "Fresh WhiteTost", "WhiteTost", 0m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mango.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class createdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<double>(type: "double", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoryName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImageUrl = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Appetizer", "Bengali food", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Frecipes.timesofindia.com%2Fphoto%2F61050397.cms%3Fimgsize%3D347173&f=1&nofb=1&ipt=3cdd2ac8943bddd345218b343980f594ba8659340471dfa65442c28a21d46246&ipo=images", "Samosa", 15.0 },
                    { 2, "Non-veg", "Bengali food", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.ytimg.com%2Fvi%2F88ZnKxw8E-s%2Fmaxresdefault.jpg&f=1&nofb=1&ipt=e6912acfb5e5be74c17550bb88a4d411faeac06912c3e81bceaa1ca494103a72&ipo=images", "Chicken Kosa", 85.0 },
                    { 3, "Dessert", "Bengali favourite sweet", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fcdn.tasteatlas.com%2FImages%2FDishes%2F65905512a4d9433780979b91393530b0.jpg%3Fmw%3D1300&f=1&nofb=1&ipt=981b7c0eaee775bfd4a8f914ac0e460608fea433077762d90e21543e5a07961b&ipo=images", "Sweet Pie", 10.0 }
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

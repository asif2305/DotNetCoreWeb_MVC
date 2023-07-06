using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Web.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedproducttotable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Abby Muscles", "This is first description", "WS102212555", 70.0, 65.0, 40.0, 60.0, "Cotton Candy" },
                    { 2, "Abby Muscles_2", "This is first description_2", "WS102212598", 50.0, 60.0, 30.0, 55.0, "Cotton Candy_2" },
                    { 3, "Abby Muscles", "This is first description_3", "WS102212563", 70.0, 65.0, 40.0, 60.0, "Cotton Candy_3" },
                    { 4, "Abby Muscles_4", "This is first description_4", "WS102212750", 60.0, 63.0, 46.0, 52.0, "Cotton Candy_4" },
                    { 5, "Abby Muscles_5", "This is first description_5", "WS102212555", 70.0, 65.0, 40.0, 60.0, "Cotton Candy_5" },
                    { 6, "Abby Muscles", "This is first description_6", "WS1022125023", 85.0, 65.0, 20.0, 80.0, "Cotton Candy_6" }
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

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcomm.Server.Migrations
{
    /// <inheritdoc />
    public partial class Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 7, 3, "A Moveable Feast is a 1964 memoir and belles-lettres by American author Ernest Hemingway about his years as a struggling expat journalist and writer in Paris during the 1920s. It was published posthumously.[1] The book details Hemingway's first marriage to Hadley Richardson and his associations with other cultural figures of the Lost Generation in Interwar France.", "https://upload.wikimedia.org/wikipedia/en/a/aa/MoveableFeast.jpg", 3.50m, "A Moveable Feast" },
                    { 8, 4, "Catching the Big Fish: Meditation, Consciousness, and Creativity, a book by film director David Lynch, is an autobiography and self-help guide comprising 84 vignette-like chapters. Lynch comments on a wide range of topics 'from metaphysics to the importance of screening your movie before a test audience.' Catching the Big Fish was inspired by Lynch's experiences with Transcendental Meditation (TM), which he began practicing in 1973. In the book, Lynch writes about his approach to filmmaking and other creative arts. Catching the Big Fish was published by Tarcher on December 28, 2006.", "https://en.wikipedia.org/wiki/Catching_the_Big_Fish#/media/File:Book_catching.png", 6.50m, "Catching the Big Fish" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}

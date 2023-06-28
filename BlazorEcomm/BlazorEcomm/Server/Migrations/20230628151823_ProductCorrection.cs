using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcomm.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/1/1f/Book_catching.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://en.wikipedia.org/wiki/Catching_the_Big_Fish#/media/File:Book_catching.png");
        }
    }
}

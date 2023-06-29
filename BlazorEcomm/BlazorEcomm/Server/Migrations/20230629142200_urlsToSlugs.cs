using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcomm.Server.Migrations
{
    /// <inheritdoc />
    public partial class urlsToSlugs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Categories",
                newName: "Slug");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "Categories",
                newName: "Url");
        }
    }
}

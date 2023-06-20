using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcomm.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
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
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "The Eye of the World is a high fantasy novel by American writer Robert Jordan, the first book of The Wheel of Time series. It was published by Tor Books and released on 15 January 1990. The unabridged audiobook is read by Michael Kramer and Kate Reading. Upon first publication, The Eye of the World consisted of one prologue and 53 chapters, with an additional prologue authored upon re-release. The book was a critical, and commercial success. Critics praised the tone, the themes, and the similarity to Lord of the Rings (although some criticized it for that).", "https://upload.wikimedia.org/wikipedia/en/0/00/WoT01_TheEyeOfTheWorld.jpg", 9.99m, "The Eye of the World" },
                    { 2, "The Way of Kings is an epic fantasy novel written by American author Brandon Sanderson and the first book in The Stormlight Archive series. The novel was published on August 31, 2010, by Tor Books. The Way of Kings consists of one prelude, one prologue, 75 chapters, an epilogue and nine interludes. It was followed by Words of Radiance in 2014, Oathbringer in 2017 and Rhythm of War in 2020. A leatherbound edition was released in 2021.", "https://upload.wikimedia.org/wikipedia/en/8/8b/TheWayOfKings.png", 10.50m, "The Way of Kings" },
                    { 3, "The story follows a band of mercenaries called Saga. The characters are likened to rock stars. The group includes Clay 'Slowhand' Cooper, 'Golden' Gabe, Ganelon, Matrick Skulldrummer, and Arcandius Moog. The characters have all grown old and out-of-shape after decades of living in retirement, but emerge from retirement to save Gabe's daughter, Rose, who is trapped in a city under siege.", "https://upload.wikimedia.org/wikipedia/en/e/ec/Kings_of_the_Wyld.jpg", 8.99m, "Kings of the Wyld" },
                    { 4, "Tortilla Flat (1935) is an early John Steinbeck novel set in Monterey, California. The novel was the author's first clear critical and commercial success. The book portrays a group of 'paisanos'—literally, countrymen—a small band of errant friends enjoying life and wine in the days after the end of World War I.", "https://upload.wikimedia.org/wikipedia/commons/d/d6/Tortilla_Flat_%281935_1st_ed_dust_jacket%29.jpg", 5.50m, "Tortilla Flat" },
                    { 5, "The story opens in Los Angeles in the 21st century, an unspecified number of years after a worldwide economic collapse. Los Angeles is no longer part of the United States since the federal government has ceded most of its power and territory to private organizations and entrepreneurs.[8] Franchising, individual sovereignty, and private vehicles reign supreme.", "https://upload.wikimedia.org/wikipedia/en/d/d5/Snowcrash.jpg", 9.50m, "Snow Crash" },
                    { 6, "First published in 1989, Hyperion has the structure of a frame story, similar to Geoffrey Chaucer's Canterbury Tales and Giovanni Boccaccio's Decameron. The story weaves the interlocking tales of a diverse group of travelers sent on a pilgrimage to the Time Tombs on Hyperion. The travelers have been sent by the Church of the Final Atonement, alternately known as the Shrike Church, and the Hegemony (the government of the human star systems) to make a request of the Shrike. ", "https://upload.wikimedia.org/wikipedia/en/7/73/Hyperion_cover.jpg", 11.50m, "Hyperion" }
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

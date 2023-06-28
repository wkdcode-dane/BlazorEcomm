﻿// <auto-generated />
using BlazorEcomm.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcomm.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230628151823_ProductCorrection")]
    partial class ProductCorrection
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorEcomm.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sci-Fi",
                            Url = "sci-fi"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fantasy",
                            Url = "fantasy"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Biography",
                            Url = "biography"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Art & Design",
                            Url = "art-and-design"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Classics",
                            Url = "classics"
                        });
                });

            modelBuilder.Entity("BlazorEcomm.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Description = "The Eye of the World is a high fantasy novel by American writer Robert Jordan, the first book of The Wheel of Time series. It was published by Tor Books and released on 15 January 1990. The unabridged audiobook is read by Michael Kramer and Kate Reading. Upon first publication, The Eye of the World consisted of one prologue and 53 chapters, with an additional prologue authored upon re-release. The book was a critical, and commercial success. Critics praised the tone, the themes, and the similarity to Lord of the Rings (although some criticized it for that).",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/00/WoT01_TheEyeOfTheWorld.jpg",
                            Price = 9.99m,
                            Title = "The Eye of the World"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "The Way of Kings is an epic fantasy novel written by American author Brandon Sanderson and the first book in The Stormlight Archive series. The novel was published on August 31, 2010, by Tor Books. The Way of Kings consists of one prelude, one prologue, 75 chapters, an epilogue and nine interludes. It was followed by Words of Radiance in 2014, Oathbringer in 2017 and Rhythm of War in 2020. A leatherbound edition was released in 2021.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/8b/TheWayOfKings.png",
                            Price = 10.50m,
                            Title = "The Way of Kings"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "The story follows a band of mercenaries called Saga. The characters are likened to rock stars. The group includes Clay 'Slowhand' Cooper, 'Golden' Gabe, Ganelon, Matrick Skulldrummer, and Arcandius Moog. The characters have all grown old and out-of-shape after decades of living in retirement, but emerge from retirement to save Gabe's daughter, Rose, who is trapped in a city under siege.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/ec/Kings_of_the_Wyld.jpg",
                            Price = 8.99m,
                            Title = "Kings of the Wyld"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 5,
                            Description = "Tortilla Flat (1935) is an early John Steinbeck novel set in Monterey, California. The novel was the author's first clear critical and commercial success. The book portrays a group of 'paisanos'—literally, countrymen—a small band of errant friends enjoying life and wine in the days after the end of World War I.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/d/d6/Tortilla_Flat_%281935_1st_ed_dust_jacket%29.jpg",
                            Price = 5.50m,
                            Title = "Tortilla Flat"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "The story opens in Los Angeles in the 21st century, an unspecified number of years after a worldwide economic collapse. Los Angeles is no longer part of the United States since the federal government has ceded most of its power and territory to private organizations and entrepreneurs.[8] Franchising, individual sovereignty, and private vehicles reign supreme.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Snowcrash.jpg",
                            Price = 9.50m,
                            Title = "Snow Crash"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "First published in 1989, Hyperion has the structure of a frame story, similar to Geoffrey Chaucer's Canterbury Tales and Giovanni Boccaccio's Decameron. The story weaves the interlocking tales of a diverse group of travelers sent on a pilgrimage to the Time Tombs on Hyperion. The travelers have been sent by the Church of the Final Atonement, alternately known as the Shrike Church, and the Hegemony (the government of the human star systems) to make a request of the Shrike. ",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/73/Hyperion_cover.jpg",
                            Price = 11.50m,
                            Title = "Hyperion"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "A Moveable Feast is a 1964 memoir and belles-lettres by American author Ernest Hemingway about his years as a struggling expat journalist and writer in Paris during the 1920s. It was published posthumously.[1] The book details Hemingway's first marriage to Hadley Richardson and his associations with other cultural figures of the Lost Generation in Interwar France.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/aa/MoveableFeast.jpg",
                            Price = 3.50m,
                            Title = "A Moveable Feast"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 4,
                            Description = "Catching the Big Fish: Meditation, Consciousness, and Creativity, a book by film director David Lynch, is an autobiography and self-help guide comprising 84 vignette-like chapters. Lynch comments on a wide range of topics 'from metaphysics to the importance of screening your movie before a test audience.' Catching the Big Fish was inspired by Lynch's experiences with Transcendental Meditation (TM), which he began practicing in 1973. In the book, Lynch writes about his approach to filmmaking and other creative arts. Catching the Big Fish was published by Tarcher on December 28, 2006.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/1f/Book_catching.png",
                            Price = 6.50m,
                            Title = "Catching the Big Fish"
                        });
                });

            modelBuilder.Entity("BlazorEcomm.Shared.Product", b =>
                {
                    b.HasOne("BlazorEcomm.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
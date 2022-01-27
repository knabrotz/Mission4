﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4.Models;

namespace Mission4.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20220127050802_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission4.Models.MovieEntry", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Category = "Drama",
                            Director = "Kenny Ortega",
                            Edited = false,
                            Rating = "G",
                            Title = "High School Musical",
                            Year = 2006
                        },
                        new
                        {
                            MovieID = 2,
                            Category = "Musical",
                            Director = "Lin-Manuel Miranda",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "tick, tick...BOOM!",
                            Year = 2021
                        },
                        new
                        {
                            MovieID = 3,
                            Category = "Animation",
                            Director = "Nathan Greno",
                            Edited = false,
                            Rating = "PG",
                            Title = "Tangled",
                            Year = 2010
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

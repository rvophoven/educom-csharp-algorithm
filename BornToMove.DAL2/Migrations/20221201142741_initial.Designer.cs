﻿// <auto-generated />
using BornToMove.DAL2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BornToMove.DAL2.Migrations
{
    [DbContext(typeof(MoveContext))]
    [Migration("20221201142741_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BornToMove.DAL2.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sweatrate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("exercises");
                });

            modelBuilder.Entity("BornToMove.DAL2.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("exer_id")
                        .HasColumnType("int");

                    b.Property<int>("intensity")
                        .HasColumnType("int");

                    b.Property<int>("ratings")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("rating");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreApp.DataAcces.Data;

#nullable disable

namespace StoreApp.DataAcces.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250202220204_addurl")]
    partial class addurl
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StoreApp.Models.CategoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Category 1"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Category 2"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Category 3"
                        });
                });

            modelBuilder.Entity("StoreApp.Models.Models.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Description = "",
                            ImageUrl = "",
                            Name = "Prod 1",
                            Price = 1.99
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "",
                            ImageUrl = "",
                            Name = "Prod 2",
                            Price = 2.9900000000000002
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "",
                            ImageUrl = "",
                            Name = "Prod 3",
                            Price = 3.9900000000000002
                        });
                });

            modelBuilder.Entity("StoreApp.Models.Models.ProductModel", b =>
                {
                    b.HasOne("StoreApp.Models.CategoryModel", "Category")
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

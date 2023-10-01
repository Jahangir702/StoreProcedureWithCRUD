﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using R54_M10_Class_09_Work_01.Models;

#nullable disable

namespace R54_M10_Class_09_Work_01.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    partial class ProductDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("R54_M10_Class_09_Work_01.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<bool?>("OnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Picture = "1jpg",
                            Price = 1014m,
                            ProductName = "Product 1",
                            Size = 2
                        },
                        new
                        {
                            ProductId = 2,
                            Picture = "2jpg",
                            Price = 1093m,
                            ProductName = "Product 2",
                            Size = 4
                        },
                        new
                        {
                            ProductId = 3,
                            Picture = "3jpg",
                            Price = 1081m,
                            ProductName = "Product 3",
                            Size = 1
                        },
                        new
                        {
                            ProductId = 4,
                            Picture = "4jpg",
                            Price = 1976m,
                            ProductName = "Product 4",
                            Size = 3
                        },
                        new
                        {
                            ProductId = 5,
                            Picture = "5jpg",
                            Price = 1109m,
                            ProductName = "Product 5",
                            Size = 4
                        });
                });

            modelBuilder.Entity("R54_M10_Class_09_Work_01.Models.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleId"));

                    b.Property<DateTime?>("Date")
                        .IsRequired()
                        .HasColumnType("date");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("Quantity")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("SaleId");

                    b.HasIndex("ProductId");

                    b.ToTable("Sales");

                    b.HasData(
                        new
                        {
                            SaleId = 1,
                            Date = new DateTime(2022, 8, 1, 17, 6, 46, 371, DateTimeKind.Local).AddTicks(9260),
                            ProductId = 1,
                            Quantity = 106
                        },
                        new
                        {
                            SaleId = 2,
                            Date = new DateTime(2022, 6, 14, 17, 6, 46, 371, DateTimeKind.Local).AddTicks(9291),
                            ProductId = 2,
                            Quantity = 127
                        },
                        new
                        {
                            SaleId = 3,
                            Date = new DateTime(2022, 7, 12, 17, 6, 46, 371, DateTimeKind.Local).AddTicks(9299),
                            ProductId = 3,
                            Quantity = 141
                        },
                        new
                        {
                            SaleId = 4,
                            Date = new DateTime(2022, 6, 16, 17, 6, 46, 371, DateTimeKind.Local).AddTicks(9307),
                            ProductId = 4,
                            Quantity = 146
                        },
                        new
                        {
                            SaleId = 5,
                            Date = new DateTime(2022, 7, 13, 17, 6, 46, 371, DateTimeKind.Local).AddTicks(9315),
                            ProductId = 5,
                            Quantity = 152
                        },
                        new
                        {
                            SaleId = 6,
                            Date = new DateTime(2022, 6, 16, 17, 6, 46, 371, DateTimeKind.Local).AddTicks(9325),
                            ProductId = 1,
                            Quantity = 196
                        },
                        new
                        {
                            SaleId = 7,
                            Date = new DateTime(2022, 7, 17, 17, 6, 46, 371, DateTimeKind.Local).AddTicks(9333),
                            ProductId = 2,
                            Quantity = 147
                        },
                        new
                        {
                            SaleId = 8,
                            Date = new DateTime(2022, 6, 11, 17, 6, 46, 371, DateTimeKind.Local).AddTicks(9341),
                            ProductId = 3,
                            Quantity = 120
                        });
                });

            modelBuilder.Entity("R54_M10_Class_09_Work_01.Models.Sale", b =>
                {
                    b.HasOne("R54_M10_Class_09_Work_01.Models.Product", "Product")
                        .WithMany("Sales")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("R54_M10_Class_09_Work_01.Models.Product", b =>
                {
                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}

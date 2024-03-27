﻿// <auto-generated />
using System;
using CatlogApi.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CatlogApi.Migrations
{
    [DbContext(typeof(ItemContext))]
    [Migration("20220718170400_itemmigration")]
    partial class itemmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CatlogApi.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreaeted")
                        .HasColumnType("datetime2");

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("category");
                });

            modelBuilder.Entity("CatlogApi.Models.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("discount");
                });

            modelBuilder.Entity("CatlogApi.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ItemCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ItemDiscountId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image_Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ratio")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.HasIndex("ItemCategoryId");

                    b.HasIndex("ItemDiscountId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("CatlogApi.Models.Item", b =>
                {
                    b.HasOne("CatlogApi.Models.Category", "ItemCategory")
                        .WithMany()
                        .HasForeignKey("ItemCategoryId");

                    b.HasOne("CatlogApi.Models.Discount", "ItemDiscount")
                        .WithMany()
                        .HasForeignKey("ItemDiscountId");

                    b.Navigation("ItemCategory");

                    b.Navigation("ItemDiscount");
                });
#pragma warning restore 612, 618
        }
    }
}
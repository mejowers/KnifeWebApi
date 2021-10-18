﻿// <auto-generated />
using System;
using KnifeWebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KnifeWebApi.Migrations
{
    [DbContext(typeof(KnifeDbContext))]
    [Migration("20211018162015_re-added models")]
    partial class readdedmodels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KnifeWebApi.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("OriginCountry")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("KnifeWebApi.Models.CostAndSale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AskingPrice")
                        .HasColumnType("decimal(11,2)");

                    b.Property<decimal>("BlueBookPrice")
                        .HasColumnType("decimal(11,2)");

                    b.Property<int>("KnifeId")
                        .HasColumnType("int");

                    b.Property<decimal>("PaidPrice")
                        .HasColumnType("decimal(11,2)");

                    b.Property<decimal>("SellPrice")
                        .HasColumnType("decimal(11,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(11,2)");

                    b.HasKey("Id");

                    b.HasIndex("KnifeId");

                    b.ToTable("CostAndSales");
                });

            modelBuilder.Entity("KnifeWebApi.Models.Knife", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("HandleMaterial")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Length")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("NumberOfBlades")
                        .HasColumnType("int");

                    b.Property<string>("PatternNumber")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("YearEra")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Knives");
                });

            modelBuilder.Entity("KnifeWebApi.Models.CostAndSale", b =>
                {
                    b.HasOne("KnifeWebApi.Models.Knife", "Knife")
                        .WithMany("CostAndSales")
                        .HasForeignKey("KnifeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Knife");
                });

            modelBuilder.Entity("KnifeWebApi.Models.Knife", b =>
                {
                    b.HasOne("KnifeWebApi.Models.Brand", "Brand")
                        .WithMany("Knives")
                        .HasForeignKey("BrandId");

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("KnifeWebApi.Models.Brand", b =>
                {
                    b.Navigation("Knives");
                });

            modelBuilder.Entity("KnifeWebApi.Models.Knife", b =>
                {
                    b.Navigation("CostAndSales");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using LineChartDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LineChartDemo.Migrations
{
    [DbContext(typeof(ApplicationDataContext))]
    [Migration("20211008140144_LineChartModels")]
    partial class LineChartModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LineChartDemo.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("LineChartDemo.Models.WeaklySales", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("ProductsId")
                        .HasColumnType("int");

                    b.Property<double>("Quantiy")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ProductsId");

                    b.ToTable("WeaklySales");
                });

            modelBuilder.Entity("LineChartDemo.Models.WeaklySales", b =>
                {
                    b.HasOne("LineChartDemo.Models.Products", "Products")
                        .WithMany()
                        .HasForeignKey("ProductsId");
                });
#pragma warning restore 612, 618
        }
    }
}

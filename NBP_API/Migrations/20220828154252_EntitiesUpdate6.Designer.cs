﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NBP_API.Entities;

#nullable disable

namespace NBP_API.Migrations
{
    [DbContext(typeof(ExchangeRatesDbContext))]
    [Migration("20220828154252_EntitiesUpdate6")]
    partial class EntitiesUpdate6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NBP_API.Entities.ExchangeRates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EffectiveDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("No")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TableType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TradingDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExchangeRates");
                });

            modelBuilder.Entity("NBP_API.Entities.Rate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExchangeRatesId")
                        .HasColumnType("int");

                    b.Property<string>("Mid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExchangeRatesId");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("NBP_API.Entities.Rate", b =>
                {
                    b.HasOne("NBP_API.Entities.ExchangeRates", "ExchangeRates")
                        .WithMany("Rates")
                        .HasForeignKey("ExchangeRatesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExchangeRates");
                });

            modelBuilder.Entity("NBP_API.Entities.ExchangeRates", b =>
                {
                    b.Navigation("Rates");
                });
#pragma warning restore 612, 618
        }
    }
}

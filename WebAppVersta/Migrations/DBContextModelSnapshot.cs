﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppVersta.Domain;

namespace WebAppVersta.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppVersta.Domain.Order", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("recieverAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("recieverTown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("senderAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("senderTown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("weight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            id = new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                            date = new DateTime(2022, 7, 17, 20, 28, 23, 697, DateTimeKind.Local).AddTicks(9743),
                            recieverAddress = "Новоизмайл",
                            recieverTown = "Санкт-Петербург",
                            senderAddress = "Тельман",
                            senderTown = "Абакан",
                            weight = "75"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

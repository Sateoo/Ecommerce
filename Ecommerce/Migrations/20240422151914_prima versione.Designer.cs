﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce.Migrations
{
    [DbContext(typeof(dbContext))]
    [Migration("20240422151914_prima versione")]
    partial class primaversione
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("Ecommerce.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataRilascio")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descrizione")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Prezzo")
                        .HasColumnType("TEXT");

                    b.Property<string>("genere")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Game");
                });
#pragma warning restore 612, 618
        }
    }
}

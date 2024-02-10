﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace massimo.macaru._5i.FORMDotNetMVC.Migrations
{
    [DbContext(typeof(dbContext))]
    partial class dbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("DatiForm", b =>
                {
                    b.Property<string>("IdPrenotazione")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cognome")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("DataDiNascita")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ruolo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sesso")
                        .HasColumnType("TEXT");

                    b.HasKey("IdPrenotazione");

                    b.ToTable("Utenti");
                });

            modelBuilder.Entity("massimo.macaru._5i.FORMDotNetMVC.Models.Prodotto", b =>
                {
                    b.Property<string>("IdProdotto")
                        .HasColumnType("TEXT");

                    b.Property<string>("Articolo")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantità")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdProdotto");

                    b.ToTable("Prodotti");
                });
#pragma warning restore 612, 618
        }
    }
}

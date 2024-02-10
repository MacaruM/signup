using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace massimo.macaru._5i.FORMDotNetMVC.Migrations
{
    /// <inheritdoc />
    public partial class Primaversionedeldb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prodotti",
                columns: table => new
                {
                    IdProdotto = table.Column<string>(type: "TEXT", nullable: false),
                    Articolo = table.Column<string>(type: "TEXT", nullable: true),
                    Quantità = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prodotti", x => x.IdProdotto);
                });

            migrationBuilder.CreateTable(
                name: "Utenti",
                columns: table => new
                {
                    IdPrenotazione = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Cognome = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    DataDiNascita = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    Sesso = table.Column<string>(type: "TEXT", nullable: true),
                    Ruolo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utenti", x => x.IdPrenotazione);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prodotti");

            migrationBuilder.DropTable(
                name: "Utenti");
        }
    }
}

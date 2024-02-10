

using massimo.macaru._5i.FORMDotNetMVC.Models;
using Microsoft.EntityFrameworkCore;


public class dbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=database.db");

    public DbSet<DatiForm> Utenti { get ; set; }
    public DbSet<Prodotto> Prodotti { get ; set; }
}
using System.ComponentModel.DataAnnotations;

namespace massimo.macaru._5i.FORMDotNetMVC.Models;

public class Prodotto
{
        [Key]
        public string IdProdotto { get; set; }
        public string? Articolo{get; set;}
        public int Quantità { get; set; }
}

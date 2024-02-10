using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using massimo.macaru._5i.FORMDotNetMVC.Models;

namespace massimo.macaru._5i.FORMDotNetMVC.Controllers;


public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private static List<Prodotto>Prodotti = new List<Prodotto>();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        HttpContext.Session.SetString("NomeUtente", "u.name");
        return View();
    }  

    public IActionResult Privacy()
    {
        string? nomeUtente = HttpContext.Session.GetString("NomeUtente");
        if (string.IsNullOrEmpty(nomeUtente))
        return Redirect("\\home\\Prenota");
        return View();
    }

    [HttpGet]
    public IActionResult Prenota()
    {

        return View();
    }

    [HttpPost]
    public IActionResult Conferma(DatiForm p)
    {
        HttpContext.Session.SetString("NomeUtente", p.Nome);
        
        return View(p);
    }
    
      public IActionResult Purchase()
    {
        return View();
    }
     public IActionResult Cart(Prodotto p)
    {
        Prodotti.Add(p);
        return View(Prodotti);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Alchemy.Models;

namespace Alchemy.Controllers;

public class Robot
    {
        private string name;
        private string url;
        private double height;
        private double weight;
        private string country;

        public string Name {get => name;}
        public string Url {get => url;}
        public double Height {get => height;}
        public double Weight {get => weight;}
        public string Country {get => country;}
        public Robot(string name, string url, double height, double weight, string country){
            this.name = name;
            this.url = url;
            this.height = height;
            this.weight = weight;
            this.country = country;
        }
    }

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    



    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["robot"] = new Robot("bob", "https://robohash.org/bob", 5, 4, "tailand");
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        );
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Alchemy.Models;

namespace Alchemy.Controllers;






public class HomeController : Controller
{

    

    


    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;

    }

    public IActionResult Index()
    {
        List<Robot> robots = new List<Robot>
        {
            new Robot("bob", "https://robohash.org/bob", 5, 4, "tailand"),
            new Robot("bob", "https://robohash.org/bob", 5, 4, "tailand"),
            new Robot("bob", "https://robohash.org/bob", 5, 4, "tailand"),
        };
        ViewData["robots"] = robots 
        ;
        return View();
    }
    public Robot Clicked(){

        Console.WriteLine("yeah");

        return new Robot("bob", "https://robohash.org/bob", 5, 4, "tailand");
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

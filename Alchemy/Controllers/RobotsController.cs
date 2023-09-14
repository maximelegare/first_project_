namespace Alchemy.Controllers;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

public class CreateRobotRequest{
    public string Name { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public string Country { get; set; }
}

public class CreateRobotResponse{
    public bool? Succeed { get; set; }
}

public class RobotsController : Controller{
    [HttpGet]
    public IActionResult Index(){
        return View();
    }
    
    [HttpPost]
    [ActionName("create-robot")]

    public IActionResult CreateRobot([FromBody] CreateRobotRequest req){
        
        ViewData["Name"] = req.Name;
        ViewData["Height"] = req.Height;
        ViewData["Weight"] = req.Weight;
        ViewData["Country"] = req.Country;
        
    



        return View("RobotPartial");
    }
}
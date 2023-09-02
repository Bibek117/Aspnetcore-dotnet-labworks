using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab26.Models;

namespace Lab26.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(int id,string name)
    {
        User newUser = new User()
        {
            Id = id,
            Name = name,
        };
        return View(newUser);
       
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

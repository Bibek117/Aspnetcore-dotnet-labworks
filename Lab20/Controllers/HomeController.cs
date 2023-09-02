using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab20.Models;


namespace Lab20.Controllers;

public class HomeController : Controller
{
        private readonly IMyService _myService;

        public HomeController(IMyService myService)
        {
            _myService = myService;
        }

        public IActionResult Index()
        {
            string message = _myService.GetMessage();
            return View((object)message);
        }
}



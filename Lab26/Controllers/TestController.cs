using Microsoft.AspNetCore.Mvc;
using Lab26.Models;
using Microsoft.AspNetCore.Http;

namespace Lab26.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("Id", 102);
            HttpContext.Session.SetString("Name", "Bibek");
            return View();
        }

        public IActionResult GetUser()
        {
            User user1 = new User()
            {
                Id = HttpContext.Session.GetInt32("Id").Value,
                Name = HttpContext.Session.GetString("Name"),
            };
            return View(user1);
        }
    }
}

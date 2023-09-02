
using Microsoft.AspNetCore.Mvc;
namespace Lab26.Controllers
{
    public class TempController : Controller
    {
        public IActionResult First()
        {
            TempData["UserId"] = 101;
            return View();
        }
        public IActionResult Second()
        {
            //var userId = TempData["UserId"];
            var userId = TempData.Peek("UserId")?.ToString();

            return View();
        }
        public IActionResult Third()
        {
            var userId = TempData["UserId"] ?? null;
            return View();
        }
    }
}

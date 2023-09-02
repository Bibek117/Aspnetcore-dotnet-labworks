using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab19.Models;
using System.Text.Json;

namespace Lab19.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Table()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Form()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Store(Student student)
    {
        if (ModelState.IsValid)
        {
            // Process and save the student data (e.g., store in memory)
            TempData["Student"] = JsonSerializer.Serialize(student);
            return RedirectToAction("Details");
        }
        return View("Form",student);
    }

    public IActionResult Details()
    {
        var studentJson = TempData["Student"] as string;
        if (string.IsNullOrEmpty(studentJson))
        {
            return RedirectToAction("Form");
        }
        var student = JsonSerializer.Deserialize<Student>(studentJson);
        return View(student);
    }
}

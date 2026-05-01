using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using English.Models;

namespace English.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

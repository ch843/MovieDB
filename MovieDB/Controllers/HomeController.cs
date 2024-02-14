using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MovieDB.Models;

namespace MovieDB.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
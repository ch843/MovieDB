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
    
    public IActionResult About()
    {
        return View();
    }
    
    public IActionResult AddMovie()
    {
        return View();
    }
}
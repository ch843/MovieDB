using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MovieDB.Models;

namespace MovieDB.Controllers;

public class HomeController : Controller
{
    private MovieContext _context;
    public HomeController(MovieContext temp)
    {
        _context = temp;
    }
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult About()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult AddMovie()
    {
        return View("AddMovie");
    }
    
    [HttpPost]
    public IActionResult AddMovie(Movie movie)
    {
        _context.Movies.Add(movie);
        _context.SaveChanges();

        return View("Index");
    }
}
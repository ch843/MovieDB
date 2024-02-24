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
        ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName)
            .ToList();
        
        return View("AddMovie");
    }
    
    [HttpPost]
    public IActionResult AddMovie(Movie movie)
    {
        _context.Movies.Add(movie);
        _context.SaveChanges();

        return View("Index");
    }
    public IActionResult Collection()
    {
        var movies = _context.Movies
            .OrderBy(x => x.Title).ToList();
        return View(movies);
    }
    
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var recordToEdit = _context.Movies
            .Single(x => x.MovieId == id);
        
        ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName)
            .ToList();
        
        return View("AddMovie", recordToEdit);
    }

    [HttpPost]
    public IActionResult Edit(Movie updatedInfo)
    {
        _context.Update(updatedInfo);
        _context.SaveChanges();
        
        return RedirectToAction("Collection");
    }

    public IActionResult Delete(int id)
    {
        var record = _context.Categories
            .Single(x => x.CategoryId == id);
        return View(record);
    }

    [HttpPost]
    public IActionResult Delete(Movie movie)
    {
        _context.Movies.Remove(movie);
        _context.SaveChanges();

        return RedirectToAction("Collection");
    }
}
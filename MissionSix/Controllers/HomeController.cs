using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MissionSix.Models;

namespace MissionSix.Controllers
{
    public class HomeController : Controller
    {
        private MoviesContext _context;

        public HomeController(MoviesContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult AboutJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie() {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie response)
        {
          
            _context.Movies.Add(response); // add record to database
            _context.SaveChanges();
            return View("Confirmation" , response);
        }
        [HttpGet]
        public IActionResult MovieList()
        {
            var movies = _context.Movies
                .ToList();

            return View("MovieList", movies);
        }



    }
}

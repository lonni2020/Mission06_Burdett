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
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie response)
        {
            _context.Movies.Add(response); // add record to database
            _context.SaveChanges();
            return View("Confirmation" , response);
        }



    }
}

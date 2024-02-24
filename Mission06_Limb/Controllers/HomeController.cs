using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Console;
using Mission06_Limb.Models;
using System.Diagnostics;

namespace Mission06_Limb.Controllers
{
    public class HomeController : Controller
    {

        private MovieEntryContext _context;
        public HomeController(MovieEntryContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieEntry()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("MovieEntry", new Movie());
        }


        [HttpPost]
        public IActionResult MovieEntry(Movie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); //Add record to database
                _context.SaveChanges();
            }
            else // invalid data
            {

                ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

                return View(response);
            }
            
            return View("Confirmation", response);
        }

        public IActionResult AboutJoel()
        {
            return View();
        }


        public IActionResult MovieList()
        {
            //linq
            var movies = _context.Movies
                .Include(m => m.Category)
                .Where(x => x.Year > 1800)
                .OrderBy(x => x.Title)
                .ToList();

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

            return View("MovieEntry", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);


        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

    }
}

using Microsoft.AspNetCore.Mvc;
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
            return View();
        }

        public IActionResult AboutJoel()
        {
            return View();
        }


        [HttpPost]
        public IActionResult MovieEntry(Entry response)
        {
            _context.Entries.Add(response); //Add record to database
            _context.SaveChanges();


            return View("Confirmation", response);
        }


    }
}

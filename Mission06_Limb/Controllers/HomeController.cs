using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Console;
using Mission06_Limb.Models;
using System.Diagnostics;

namespace Mission06_Limb.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieEntry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieEntry(Entry response)
        {
            return View("Confirmation", response);
        }


    }
}

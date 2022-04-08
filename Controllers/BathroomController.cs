using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SustainableAlternatives.Controllers
{
    public class BathroomController : Controller
    {
        // GET: /<controller>/
        public IActionResult CommonProducts()
        {
            return View();
        }
        public IActionResult Dental()
        {
            return View();
        }
        public IActionResult Sundries()
        {
            return View();
        }
        public IActionResult Styling()
        {
            return View();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SustainableAlternatives.Controllers
{
    public class KitchenController : Controller
    {
        // GET: /<controller>/
        public IActionResult Cleaning()
        {
            return View();
        }

        public IActionResult Kitchenware()
        {
            return View();
        }

        public IActionResult ProduceAndIngredients()
        {
            return View();
        }

        public IActionResult WrapsAndStorage()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication23.Models;

namespace WebApplication23.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Arithmetic Calc)
        {
            if(Calc.Calculation == "Addition")
            {
                Calc.Result = Calc.Firstnumber + Calc.Secondnumber;
            }

            if (Calc.Calculation == "Subtraction")
            {
                Calc.Result = Calc.Firstnumber - Calc.Secondnumber;
            }
            if (Calc.Calculation == "Multiplication")
            {
                Calc.Result = Calc.Firstnumber * Calc.Secondnumber;
            }
            if (Calc.Calculation == "Division")
            {
                Calc.Result = Calc.Firstnumber + Calc.Secondnumber;
            }


            return View(Calc);
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

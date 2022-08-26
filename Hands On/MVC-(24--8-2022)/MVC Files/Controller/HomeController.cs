using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Palindromes.Models;

namespace Palindromes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Palindromee sc)
        {
            int num = sc.firstnumber;
            int rev = 0;

            for (; num > 0;)
            {
                int rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            if (rev == sc.firstnumber)
            {
                sc.result = "It is a Palindrome";
            }
            else
            {
                sc.result = "It is not a Palindrome";
            }
            return View(sc);
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

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace ARAPlus.AspWebMitMVC.Controllers
{
    public class ARAPlusController : Controller
    {
        //HelloWorld/Index/
        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
           // return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {id}");
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            ViewBag.Begruessung = "Hello Graz";

            return View();
        }

        public IActionResult Goodbye()
        {
            ViewData["Daten"] = "Danke für Ihren Besuch";
            return View();
        }
    }
}

using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        [ResponseCache(Duration =10000, Location =ResponseCacheLocation.Client)]
        public IActionResult  Index()
        {
            return new JsonResult(System.DateTime.Now.ToLongTimeString());
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

        [HttpGet]
        public IActionResult Servus(string s)
        {
            ViewData["Daten"] = "Danke für Ihren Besuch";
            return View();
        }

        [HttpPost]
        public IActionResult Servus()
        {
            ViewData["Daten"] = "Danke für Ihren Besuch";
            return View();
        }
    }
}

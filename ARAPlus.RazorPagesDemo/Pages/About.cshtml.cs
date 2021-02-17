using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARAPlus.RazorPagesDemo.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }
        public string Vorname { get; set; }

        public void OnGet()
        {
            ViewData["Nachname"] = "Grabner";
            Message = "Your application description page.";
            Vorname = "Johann";
        }
    }
}

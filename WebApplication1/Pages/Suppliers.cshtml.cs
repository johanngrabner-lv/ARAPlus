using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ARAPlus.DatabaseSample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class SuppliersModel : PageModel
    {
        public IEnumerable<string> Suppliers { get; set; }

        private NorthwindContext db;
        public SuppliersModel(NorthwindContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            ViewData["Title"] = "Northwind Web Site - Suppliers";
            //Suppliers = new[] {"Alpha Co", "Beta Limited", "Gamma Corp"
            Suppliers = db.Suppliers.Select(s => s.CompanyName);
        
        }
        [BindProperty]
        public Supplier Supplier { get; set; }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Supplier.SupplierId = 10000;
                db.Suppliers.Add(Supplier);
                db.SaveChanges();
                return RedirectToPage("/suppliers");
            }
            Suppliers = db.Suppliers.Select(s => s.CompanyName);
            return Page();
        }
    }
}

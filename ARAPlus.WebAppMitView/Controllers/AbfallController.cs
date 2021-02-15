using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARAPlus.WebAppMitView.Controllers
{
    public class AbfallController : Controller
    {
        // GET: AbfallController
        public ActionResult Index()
        {
            ARAPlus.AbfallLogic.Abfall abfall = new ARAPlus.AbfallLogic.Abfall();
            abfall.Bezeichnung = "Montag";
            abfall.Preis = 120;
            abfall.Gewicht = 20;

            return View(abfall);
        }

        // GET: AbfallController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AbfallController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AbfallController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AbfallController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AbfallController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AbfallController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AbfallController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

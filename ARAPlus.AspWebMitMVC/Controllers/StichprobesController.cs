using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ARAPlus.AspWebMitMVC.Models;

namespace ARAPlus.AspWebMitMVC.Controllers
{
    public class StichprobesController : Controller
    {
        private readonly StichprobenContext _context;

        public StichprobesController(StichprobenContext context)
        {
            _context = context;
        }

        // GET: Stichprobes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Stichprobe.ToListAsync());
        }

        // GET: Stichprobes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stichprobe = await _context.Stichprobe
                .FirstOrDefaultAsync(m => m.StichprobeId == id);
            if (stichprobe == null)
            {
                return NotFound();
            }

            return View(stichprobe);
        }

        // GET: Stichprobes/Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Anweisung = "Bitte füllen Sie die Stichprobe aus";

            ViewBag.Stichprobe = new Stichprobe() { Gefahrengut = true, Name="Ein TEst für ViewBag" };

            return View();
        }

        // POST: Stichprobes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StichprobeId,Name,Abgabedatum,Gefahrengut")] Stichprobe stichprobe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stichprobe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stichprobe);
            //return View("en",stichprobe);
            // return View("de", stichprobe);
        }

        // GET: Stichprobes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stichprobe = await _context.Stichprobe.FindAsync(id);
            if (stichprobe == null)
            {
                return NotFound();
            }
            return View(stichprobe);
        }

        // POST: Stichprobes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StichprobeId,Name,Abgabedatum,Gefahrengut")] Stichprobe stichprobe)
        {
            if (id != stichprobe.StichprobeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stichprobe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StichprobeExists(stichprobe.StichprobeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(stichprobe);
        }

        // GET: Stichprobes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stichprobe = await _context.Stichprobe
                .FirstOrDefaultAsync(m => m.StichprobeId == id);
            if (stichprobe == null)
            {
                return NotFound();
            }

            return View(stichprobe);
        }

        // POST: Stichprobes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stichprobe = await _context.Stichprobe.FindAsync(id);
            _context.Stichprobe.Remove(stichprobe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StichprobeExists(int id)
        {
            return _context.Stichprobe.Any(e => e.StichprobeId == id);
        }
    }
}

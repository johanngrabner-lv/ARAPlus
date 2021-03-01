using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ARAPlus.AspWebMitMVC.Models;

namespace ARAPlus.AspWebMitMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StichprobenApiController : ControllerBase
    {
        private readonly StichprobenContext _context;

        public StichprobenApiController(StichprobenContext context)
        {
            _context = context;
        }

        // GET: api/StichprobenApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stichprobe>>> GetStichprobe()
        {
            return await _context.Stichprobe.ToListAsync();
        }

        // GET: api/StichprobenApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Stichprobe>> GetStichprobe(int id)
        {
            var stichprobe = await _context.Stichprobe.FindAsync(id);

            if (stichprobe == null)
            {
                return NotFound();
            }

            return stichprobe;
        }

        // PUT: api/StichprobenApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStichprobe(int id, Stichprobe stichprobe)
        {
            if (id != stichprobe.StichprobeId)
            {
                return BadRequest();
            }

            _context.Entry(stichprobe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StichprobeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/StichprobenApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Stichprobe>> PostStichprobe(Stichprobe stichprobe)
        {
           // if (ModelState.IsValid)
            {
                _context.Stichprobe.Add(stichprobe);
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetStichprobe", new { id = stichprobe.StichprobeId }, stichprobe);
            }

            //return BadRequest();
            
        }

        // DELETE: api/StichprobenApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStichprobe(int id)
        {
            var stichprobe = await _context.Stichprobe.FindAsync(id);
            if (stichprobe == null)
            {
                return NotFound();
            }

            _context.Stichprobe.Remove(stichprobe);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StichprobeExists(int id)
        {
            return _context.Stichprobe.Any(e => e.StichprobeId == id);
        }
    }
}

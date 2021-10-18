using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KnifeWebApi.Data;
using KnifeWebApi.Models;

namespace KnifeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KnivesController : ControllerBase
    {
        private readonly KnifeDbContext _context;

        public KnivesController(KnifeDbContext context)
        {
            _context = context;
        }

        // GET: api/Knives
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Knife>>> GetKnives()
        {
            return await _context.Knives.ToListAsync();
        }

        // GET: api/Knives/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Knife>> GetKnife(int id)
        {
            var knife = await _context.Knives.FindAsync(id);

            if (knife == null)
            {
                return NotFound();
            }

            return knife;
        }

        // PUT: api/Knives/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKnife(int id, Knife knife)
        {
            if (id != knife.Id)
            {
                return BadRequest();
            }

            _context.Entry(knife).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KnifeExists(id))
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

        // POST: api/Knives
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Knife>> PostKnife(Knife knife)
        {
            _context.Knives.Add(knife);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKnife", new { id = knife.Id }, knife);
        }

        // DELETE: api/Knives/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKnife(int id)
        {
            var knife = await _context.Knives.FindAsync(id);
            if (knife == null)
            {
                return NotFound();
            }

            _context.Knives.Remove(knife);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KnifeExists(int id)
        {
            return _context.Knives.Any(e => e.Id == id);
        }
    }
}

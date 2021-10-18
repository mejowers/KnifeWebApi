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
    public class CostAndSalesController : ControllerBase
    {
        private readonly KnifeDbContext _context;

        public CostAndSalesController(KnifeDbContext context)
        {
            _context = context;
        }

        // GET: api/CostAndSales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CostAndSale>>> GetCostAndSales()
        {
            return await _context.CostAndSales.ToListAsync();
        }

        // GET: api/CostAndSales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CostAndSale>> GetCostAndSale(int id)
        {
            var costAndSale = await _context.CostAndSales.FindAsync(id);

            if (costAndSale == null)
            {
                return NotFound();
            }

            return costAndSale;
        }

        // PUT: api/CostAndSales/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCostAndSale(int id, CostAndSale costAndSale)
        {
            if (id != costAndSale.Id)
            {
                return BadRequest();
            }

            _context.Entry(costAndSale).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CostAndSaleExists(id))
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

        // POST: api/CostAndSales
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CostAndSale>> PostCostAndSale(CostAndSale costAndSale)
        {
            _context.CostAndSales.Add(costAndSale);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCostAndSale", new { id = costAndSale.Id }, costAndSale);
        }

        // DELETE: api/CostAndSales/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCostAndSale(int id)
        {
            var costAndSale = await _context.CostAndSales.FindAsync(id);
            if (costAndSale == null)
            {
                return NotFound();
            }

            _context.CostAndSales.Remove(costAndSale);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CostAndSaleExists(int id)
        {
            return _context.CostAndSales.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mini_ERP_API.Models;

namespace Mini_ERP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlmaceneController : ControllerBase
    {
        private readonly MinierpContext _context;

        public AlmaceneController(MinierpContext context)
        {
            _context = context;
        }

        // GET: api/Almacene
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Almacene>>> GetAlmacenes()
        {
            return await _context.Almacenes.ToListAsync();
        }

        // GET: api/Almacene/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Almacene>> GetAlmacene(string id)
        {
            var almacene = await _context.Almacenes.FindAsync(id);

            if (almacene == null)
            {
                return NotFound();
            }

            return almacene;
        }

        // PUT: api/Almacene/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlmacene(string id, Almacene almacene)
        {
            if (id != almacene.Clave)
            {
                return BadRequest();
            }

            _context.Entry(almacene).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlmaceneExists(id))
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

        // POST: api/Almacene
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Almacene>> PostAlmacene(Almacene almacene)
        {
            _context.Almacenes.Add(almacene);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AlmaceneExists(almacene.Clave))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAlmacene", new { id = almacene.Clave }, almacene);
        }

        // DELETE: api/Almacene/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlmacene(string id)
        {
            var almacene = await _context.Almacenes.FindAsync(id);
            if (almacene == null)
            {
                return NotFound();
            }

            _context.Almacenes.Remove(almacene);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlmaceneExists(string id)
        {
            return _context.Almacenes.Any(e => e.Clave == id);
        }
    }
}

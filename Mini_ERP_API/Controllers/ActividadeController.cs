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
    public class ActividadeController : ControllerBase
    {
        private readonly MinierpContext _context;

        public ActividadeController(MinierpContext context)
        {
            _context = context;
        }

        // GET: api/Actividade
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actividade>>> GetActividades()
        {
            return await _context.Actividades.ToListAsync();
        }

        // GET: api/Actividade/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Actividade>> GetActividade(string id)
        {
            var actividade = await _context.Actividades.FindAsync(id);

            if (actividade == null)
            {
                return NotFound();
            }

            return actividade;
        }

        // PUT: api/Actividade/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActividade(string id, Actividade actividade)
        {
            if (id != actividade.IdActividad)
            {
                return BadRequest();
            }

            _context.Entry(actividade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActividadeExists(id))
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

        // POST: api/Actividade
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Actividade>> PostActividade(Actividade actividade)
        {
            _context.Actividades.Add(actividade);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ActividadeExists(actividade.IdActividad))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetActividade", new { id = actividade.IdActividad }, actividade);
        }

        // DELETE: api/Actividade/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActividade(string id)
        {
            var actividade = await _context.Actividades.FindAsync(id);
            if (actividade == null)
            {
                return NotFound();
            }

            _context.Actividades.Remove(actividade);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ActividadeExists(string id)
        {
            return _context.Actividades.Any(e => e.IdActividad == id);
        }
    }
}

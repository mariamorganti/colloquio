using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using colloquio.Models;
using colloquio.Service;
using Microsoft.AspNetCore.Http.HttpResults;

namespace colloquio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusteOperatoresController : ControllerBase
    {
        private readonly GestionematerialitaContext _context;
        private readonly IBustaOperatore _bustaOperatore;
        public BusteOperatoresController(GestionematerialitaContext context, IBustaOperatore BustaOperatore)
        {
            _context = context;
            _bustaOperatore = BustaOperatore;
        }

        // GET: api/BusteOperatores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BusteOperatore>>> GetBusteOperatores()
        {
            return await _context.BusteOperatores.ToListAsync();
        }

        // GET: api/BusteOperatores/5
        [HttpGet("{IdBusta}")]
        public async Task<ActionResult<BusteOperatore>> GetBusteOperatoreOld(string IdBusta)
        {
            var busteOperatore = await _context.BusteOperatores.FirstOrDefaultAsync(id => id.IdBusta == IdBusta);

            if (busteOperatore == null)
            {
                return NotFound();
            }

            return busteOperatore;
        }
        [HttpGet("GetBusteOperatoreByService{IdBusta}")]
        public async Task<ActionResult<BusteOperatore>> GetBusteOperatore(string IdBusta)
        {
            var busteOperatore = await _bustaOperatore.GetBusteOperatore(IdBusta);

            if (busteOperatore == null)
            {
                return NotFound();
            }

            return Ok(busteOperatore);
        }

        [HttpGet("GetBusteOperatoreRicevute{IdBusta}")]
        public async Task<ActionResult<BusteOperatore>> GetBusteOperatoreRicevute(string IdBusta)
        {
            var busteOperatore = await _bustaOperatore.GetBusteOperatoreRicevuteBO(IdBusta);

            if (busteOperatore == null)
            {
                return NotFound();
            }

            return Ok(busteOperatore);
        }

        // PUT: api/BusteOperatores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBusteOperatore(string id, BusteOperatore busteOperatore)
        {
            if (id != busteOperatore.IdBusta)
            {
                return BadRequest();
            }
             

            _context.Entry(busteOperatore).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusteOperatoreExists(id))
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

        // POST: api/BusteOperatores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BusteOperatore>> PostBusteOperatore(BusteOperatore busteOperatore)
        {
            _context.BusteOperatores.Add(busteOperatore);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BusteOperatoreExists(busteOperatore.IdBusta))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBusteOperatore", new { id = busteOperatore.IdBusta }, busteOperatore);
        }

        // DELETE: api/BusteOperatores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBusteOperatore(string id)
        {
            var busteOperatore = await _context.BusteOperatores.FindAsync(id);
            if (busteOperatore == null)
            {
                return NotFound();
            }

            _context.BusteOperatores.Remove(busteOperatore);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BusteOperatoreExists(string id)
        {
            return _context.BusteOperatores.Any(e => e.IdBusta == id);
        }
    }
}

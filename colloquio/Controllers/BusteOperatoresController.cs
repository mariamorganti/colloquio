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

        [HttpGet("EfOrderBy{Frazionario}")]
        public   async Task<ActionResult<IEnumerable<BusteOperatore>>> EfOrderBy(string Frazionario)
        {
            //var BOOrderByIDBusta = await _context.BusteOperatores
            //                        .Where(b => b.Frazionario == Frazionario)
            //                        .OrderBy(b => b.IdBusta)
            //                        .ToListAsync();
            var BOOrderByIDBusta = await (from BO in _context.BusteOperatores
                                   where BO.Frazionario == Frazionario
                                   orderby BO.IdBusta
                                   select BO).ToListAsync();
            return BOOrderByIDBusta;
 
        }

        //[HttpGet("EfGroupBy{Frazionario}")] 
        //public async Task<ActionResult<IEnumerable<IGrouping<string, BusteOperatore>>>> EfGroupBy(string Frazionario)
        //{
        //    var gruppiFrazionari = await (from BO in _context.BusteOperatores
        //                                  where BO.Frazionario == Frazionario
        //                                  group BO by BO.Frazionario into gruppofraz
        //                                  select gruppofraz).ToListAsync();

        //    return gruppiFrazionari;
        //}

        [HttpGet("EfGroupBy{Frazionario}")]
        public void    EfGroupBy(string Frazionario)
        {
            var gruppiFrazionari =  (from BO in _context.BusteOperatores
                                          where BO.Frazionario == Frazionario
                                          group BO by BO.IdBusta into gruppoIdBusta
                                     select gruppoIdBusta).ToListAsync();
            var sss = gruppiFrazionari;

            //return gruppiFrazionari;
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
        [HttpGet("GetIndiceFromEnd{indice}")]
        public  ActionResult<string>  GetIndiceFromEnd(int indice)
        {
            //index from end c#
            string[] myArray = { "primo", "secondo", "terzo", "quarto", "quinto" };
            string s =   myArray[^indice];
            return Ok(s);
        }

        [HttpGet("GetRange")] 
        public string[] GetRange(  int inzio, int fine)
        {
             
            string[] myArray = { "primo", "secondo", "terzo", "quarto", "quinto" };
            //string[] s = myArray[inzio..fine];
            int ultimo = myArray.Length ;
            string[] s = myArray[inzio..ultimo];

            return s;
        }
        [HttpGet("GetSpread")]
        public string?[] GetSpread()
        {
            string?[] myArray1 = { "primo", "secondo", "terzo", "quarto", "quinto" };
            string?[] myArray2 = { "sesto", "settimo", "ottavo", "nono", "decimo" };

           //string?[] combinedArray = [..myArray1, ..myArray2];

            return myArray2;
        }
        [HttpGet("GetValueRefenceType")]
        public int GetValueRefenceType()
        {
            int x = 120;
            int y = x;
            Console.WriteLine($"y prima : {y}");

            x = 50;
            Console.WriteLine($"y DOPO : {y}");
            return y;
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
        //public bool MagDi(int n1, int n2) { 
        //    return  (n1 > n2) ? true : false;
        //}
        //public bool MinDi(int n1, int n2)
        //{
        //    return (n1 < n2) ? true : false;
        //}
        //public bool UgualeA(int n1, int n2)
        //{
        //    return (n1 == 2) ? true : false;
        //}
    }
}

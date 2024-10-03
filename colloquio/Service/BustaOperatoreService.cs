using colloquio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace colloquio.Service
{
    public class BustaOperatoreService:IBustaOperatore
    {
        private GestionematerialitaContext _gestionematerialitaContext;
        public BustaOperatoreService(GestionematerialitaContext gestionematerialitaContext) 
        {
            _gestionematerialitaContext = gestionematerialitaContext;
        }
       public async Task<BusteOperatore> GetBusteOperatore(string IdBusta)
        {
            var busteOperatore = await _gestionematerialitaContext.BusteOperatores.FirstOrDefaultAsync(id => id.IdBusta == IdBusta);

            if (busteOperatore is null)
            {
                return null;
            }

            return busteOperatore;
        }

        public async Task<object?> GetBusteOperatoreRicevuteBO(string IdBusta)
        {
            var busteOperatore = await _gestionematerialitaContext.BusteOperatores.
                Where(id=> id.IdBusta == IdBusta)
                .GroupJoin( _gestionematerialitaContext.RicevuteBustaOperatores,
                buste=> buste.IdBusta,
                ricevute=> ricevute.IdBusta,
                (buste, ricevute)=> new  
                {
                    Buste = buste ,
                    Ricevute = ricevute 

                }
                ).ToListAsync();    

            if (busteOperatore is null)
            {
                return null;
            }

            return busteOperatore;
        }
    }
}

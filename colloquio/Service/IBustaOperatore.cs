using colloquio.Models;
using Microsoft.AspNetCore.Mvc;

namespace colloquio.Service
{
    public interface IBustaOperatore 
    {
        Task<BusteOperatore> GetBusteOperatore(string IdBusta);
        Task<object?> GetBusteOperatoreRicevuteBO(string IdBusta);
    }
}

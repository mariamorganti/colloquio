using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class RicercheStoriche
{
    public int IdRicerca { get; set; }

    public string? UserId { get; set; }

    public string StatoRicerca { get; set; } = null!;

    public DateTime DataInizioRicerca { get; set; }

    public DateTime? DataFineRicerca { get; set; }

    public int FiltroTipoRicerca { get; set; }

    public string? FiltroFrazionario { get; set; }

    public DateOnly? FiltroData { get; set; }

    public DateOnly? FiltroDataDa { get; set; }

    public DateOnly? FiltroDataA { get; set; }

    public string? FiltroCategoria { get; set; }

    public string? FiltroSottocategoria { get; set; }

    public string? FiltroCodiceFase { get; set; }

    public string? FiltroIdBusta { get; set; }

    public string? FiltroTipoElemento { get; set; }

    public string? FiltroStatoBusta { get; set; }

    public string? FiltroUtenza { get; set; }

    public string? FiltroIdScatola { get; set; }

    public string? FiltroCodiceRaccomandata { get; set; }

    public string? FiltroStatoScatola { get; set; }

    public int? IdRicercaPadre { get; set; }

    public DateTime? FiltroDataAscatolaInviata { get; set; }

    public DateTime? FiltroDataDaScatolaInviata { get; set; }

    public DateTime? FiltroDataScatolaInviata { get; set; }

    public virtual ICollection<AltriFiltri> AltriFiltris { get; set; } = new List<AltriFiltri>();

    public virtual ICollection<ResponseRicercheStoriche> ResponseRicercheStoriches { get; set; } = new List<ResponseRicercheStoriche>();
}

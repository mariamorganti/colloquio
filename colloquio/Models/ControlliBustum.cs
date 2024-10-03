using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class ControlliBustum
{
    public string IdControllo { get; set; } = null!;

    public string IdBusta { get; set; } = null!;

    public string CodiceOperatore { get; set; } = null!;

    public string? CodiceOperatoreEsecuzione { get; set; }

    public string Frazionario { get; set; } = null!;

    public string Stato { get; set; } = null!;

    public bool? Contraddittorio { get; set; }

    public string? CausaleMancanzaContraddittorio { get; set; }

    public string? Note { get; set; }

    public DateTime DataCreazione { get; set; }

    public DateTime DataModifica { get; set; }

    public DateTime? DataEsecuzione { get; set; }

    public bool? ControlloConformita { get; set; }

    public string? Tipologia { get; set; }
}

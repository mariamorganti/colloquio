using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class BusteEccezioni
{
    public string IdBusta { get; set; } = null!;

    public string CodiceOperatoreApertura { get; set; } = null!;

    public string CodiceOperatoreModifica { get; set; } = null!;

    public string Frazionario { get; set; } = null!;

    public DateTime DataApertura { get; set; }

    public string Stato { get; set; } = null!;

    public string? IdScatola { get; set; }

    public DateTime DataModifica { get; set; }

    public DateTime? DataChiusura { get; set; }

    public string CodiceOperatore { get; set; } = null!;

    public DateTime DataContabile { get; set; }

    public DateTime? DataCreazione { get; set; }

    public int TotaleRicevuteInBusta { get; set; }
    public int TotaleRicevuteInBustaTest { get; set; }
}

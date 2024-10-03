using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class BusteOperatore
{
    public string IdBusta { get; set; } = null!;

    public string CodiceOperatore { get; set; } = null!;

    public string CodiceOperatoreModifica { get; set; } = null!;

    public string Frazionario { get; set; } = null!;

    public string Stato { get; set; } = null!;

    public DateTime DataApertura { get; set; }

    public DateOnly DataContabile { get; set; }

    public DateTime? DataChiusura { get; set; }

    public DateTime? DataRitrovamento { get; set; }

    public DateTime? DataUltimoControllo { get; set; }

    public string? CodiceOperatoreChiusura { get; set; }

    public string? IdScatola { get; set; }

    public bool Squadratura { get; set; }

    public int TotaleRicevuteInBusta { get; set; }

    public int TotaleOperazioniConCartaceo { get; set; }

    public DateTime DataCreazione { get; set; }

    public DateTime DataModifica { get; set; }

    public DateTime? DataAssociazione { get; set; }

    public DateTime? DataSmarrimento { get; set; }
}

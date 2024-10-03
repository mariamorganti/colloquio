using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class Frazionari
{
    public string Codice { get; set; } = null!;

    public string Descrizione { get; set; } = null!;

    public bool ControlloProduttivita { get; set; }

    public bool ControlloTemporale { get; set; }

    public DateTime? DataUltimoControllo { get; set; }

    public int Produttivita { get; set; }

    public DateTime DataCreazione { get; set; }

    public DateTime DataModifica { get; set; }

    public DateOnly? DataPassaggioGema { get; set; }

    public bool? FlagControlloAutomatico { get; set; }
}

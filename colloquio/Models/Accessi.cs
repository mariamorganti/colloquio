using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class Accessi
{
    public string Ruolo { get; set; } = null!;

    public string? Visibilita { get; set; }

    public bool RicercaOperazioni { get; set; }

    public bool RicercaBuste { get; set; }

    public bool RicercaScatole { get; set; }

    public bool GestioneScatole { get; set; }

    public bool RecuperoRicevuta { get; set; }

    public string? NoteProfilo { get; set; }

    public bool? ModificaStato { get; set; }
    public bool? ModificaStatoBis { get; set; }
}

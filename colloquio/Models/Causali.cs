using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class Causali
{
    public string IdCausale { get; set; } = null!;

    public string Descrizione { get; set; } = null!;

    public DateTime InizioValidita { get; set; }

    public DateTime FineValidita { get; set; }

    public string CodiceFase { get; set; } = null!;
}

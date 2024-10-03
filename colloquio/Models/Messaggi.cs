using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class Messaggi
{
    public string IdMessaggio { get; set; } = null!;

    public string? Titolo { get; set; }

    public string? Stato { get; set; }

    public string? TestoMessaggio { get; set; }

    public bool Abilitato { get; set; }
}

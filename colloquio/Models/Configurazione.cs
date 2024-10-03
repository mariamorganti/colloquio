using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class Configurazione
{
    public string Chiave { get; set; } = null!;

    public string Valore { get; set; } = null!;

    public string? Descrizione { get; set; }
}

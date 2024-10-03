using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class FormattazioneFasiGectnew
{
    public string CodiceFase { get; set; } = null!;

    public string? Formattazione { get; set; }

    public int TipoCluster { get; set; }

    public string? NoteTipoCluster { get; set; }
}

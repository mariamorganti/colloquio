using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class ValoriBusteCampiDocumento
{
    public long Id { get; set; }

    public long DocumentiBusteBackOfficeId { get; set; }

    public string NomeCampo { get; set; } = null!;

    public string? Valore { get; set; }
}

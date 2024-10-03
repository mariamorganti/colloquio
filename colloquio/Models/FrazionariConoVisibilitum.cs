using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class FrazionariConoVisibilitum
{
    public string Codice { get; set; } = null!;

    public string? Descrizione { get; set; }

    public DateTime DataCreazione { get; set; }

    public string? IdFiliale { get; set; }

    public string? IdMacroArea { get; set; }
}

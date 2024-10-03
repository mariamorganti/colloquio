using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class ControlliBustaTemporanea
{
    public string IdControllo { get; set; } = null!;

    public string? IdBusta { get; set; }

    public string? Frazionario { get; set; }
}

using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class Test
{
    public DateOnly? Data { get; set; }

    public string? Esito { get; set; }

    public string? Note { get; set; }

    public string? Altro { get; set; }

    public string? Stato { get; set; }
}

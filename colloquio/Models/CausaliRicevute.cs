using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class CausaliRicevute
{
    public int Id { get; set; }

    public string IdCausale { get; set; } = null!;

    public long CodiceOperazione { get; set; }

    public string IdControllo { get; set; } = null!;

    public string? NoteConformita { get; set; }
}

using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class SysRicercheOperazioni
{
    public int Id { get; set; }

    public string TipoRicerca { get; set; } = null!;

    public string Request { get; set; } = null!;

    public string? Response { get; set; }

    public string? Esito { get; set; }

    public DateTime Start { get; set; }

    public DateTime? Stop { get; set; }
}

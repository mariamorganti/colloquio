using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class AnomalieBustum
{
    public long Id { get; set; }

    public string IdControllo { get; set; } = null!;

    public string IdBusta { get; set; } = null!;

    public string Frazionario { get; set; } = null!;

    public long CodiceOperazione { get; set; }

    public string Titolo { get; set; } = null!;

    public string CodiceFase { get; set; } = null!;

    public string CodicePdL { get; set; } = null!;

    public string CodiceOperatore { get; set; } = null!;

    public decimal? Importo { get; set; }

    public string? Motivazione { get; set; }

    public bool Asserita { get; set; }

    public bool Riscontrata { get; set; }

    public DateTime DataCreazione { get; set; }
}

using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class RicevuteBustaOperatoreHistory
{
    public long CodiceOperazione { get; set; }

    public string? IdBusta { get; set; }

    public string Frazionario { get; set; } = null!;

    public DateOnly DataContabile { get; set; }

    public int ProgressivoOperazione { get; set; }

    public string Titolo { get; set; } = null!;

    public string CodiceFase { get; set; } = null!;

    public string TipoOperazione { get; set; } = null!;

    public string CodicePdl { get; set; } = null!;

    public DateTime DataOperazione { get; set; }

    public decimal? Importo { get; set; }

    public string? NumeroCassa { get; set; }

    public string CodiceOperatore { get; set; } = null!;

    public string CodiceOperatoreModifica { get; set; } = null!;

    public bool Assenza { get; set; }

    public string? MotivazioneAssenza { get; set; }

    public string Stato { get; set; } = null!;

    public bool Controtransata { get; set; }

    public DateTime DataCreazione { get; set; }

    public DateTime DataModifica { get; set; }
}

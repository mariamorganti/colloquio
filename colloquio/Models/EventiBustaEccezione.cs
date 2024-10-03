using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class EventiBustaEccezione
{
    public string IdBusta { get; set; } = null!;

    public DateTime DataEvento { get; set; }

    public string Evento { get; set; } = null!;

    public string StatoIniziale { get; set; } = null!;

    public string StatoFinale { get; set; } = null!;

    public string CodiceOperatore { get; set; } = null!;

    public string? Metadati { get; set; }

    public bool Errore { get; set; }

    public string? DescrizioneErrore { get; set; }
}

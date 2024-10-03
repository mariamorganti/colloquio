using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class Fasi
{
    public string CodiceFase { get; set; } = null!;

    public int VersSoftInizio { get; set; }

    public int VersSoftFine { get; set; }

    public DateTime DataInizioValidita { get; set; }

    public DateTime DataFineValidita { get; set; }

    public string Tipologia { get; set; } = null!;

    public string Titolo { get; set; } = null!;

    public string? CodiceFormaTecnica1 { get; set; }

    public string? CodiceFormaTecnica2 { get; set; }

    public string? Descrizione { get; set; }

    public string? ClasseDocumentaleGect { get; set; }

    public string? ClasseDocumentaleGectcontroTransazione { get; set; }

    public decimal? FattoreScalaStampa { get; set; }

    public string? TabellaAcbWeb { get; set; }

    public bool ControlloConformita { get; set; }
}

using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class CTipologicaDocumentiCollaudo
{
    public string NomeDocumento { get; set; } = null!;

    public string? Descrizione { get; set; }

    public string Tipo { get; set; } = null!;

    public DateTime? InizioValidita { get; set; }

    public DateTime? FineValidita { get; set; }

    public int? ParentId { get; set; }
}

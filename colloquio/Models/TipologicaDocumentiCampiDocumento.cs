using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class TipologicaDocumentiCampiDocumento
{
    public string NomeDocumento { get; set; } = null!;

    public string NomeCampo { get; set; } = null!;

    public decimal? Ordine { get; set; }
}

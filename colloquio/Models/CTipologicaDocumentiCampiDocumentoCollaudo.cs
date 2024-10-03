using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class CTipologicaDocumentiCampiDocumentoCollaudo
{
    public string NomeDocumento { get; set; } = null!;

    public string NomeCampo { get; set; } = null!;

    public decimal? Ordine { get; set; }
}

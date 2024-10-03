using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class DocumentiBusteBackOffice
{
    public long Id { get; set; }

    public string? IdBusta { get; set; }

    public string NomeDocumento { get; set; } = null!;

    public DateTime? DataInserimento { get; set; }
}

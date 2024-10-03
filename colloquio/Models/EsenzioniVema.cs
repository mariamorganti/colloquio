using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class EsenzioniVema
{
    public string CodiceOperatore { get; set; } = null!;

    public DateOnly DataInserimento { get; set; }
}

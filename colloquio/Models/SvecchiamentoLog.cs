using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class SvecchiamentoLog
{
    public int Id { get; set; }

    public DateTime? ExecutionDateTime { get; set; }

    public string? Status { get; set; }

    public string? Log { get; set; }
}

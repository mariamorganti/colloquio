using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class StatisticheKafka
{
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string TipoTable { get; set; } = null!;

    public string TipoOperazione { get; set; } = null!;

    public int? Tot { get; set; }
}

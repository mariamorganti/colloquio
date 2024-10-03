using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class MonitoringScatole
{
    public int IdMonitoringScatole { get; set; }

    public DateTime? Data { get; set; }

    public string Frazionario { get; set; } = null!;

    public string IdScatola { get; set; } = null!;

    public DateTime DataInizioAfferenza { get; set; }

    public DateTime? DataFineAfferenza { get; set; }

    public string? StatoDa { get; set; }

    public string? StatoA { get; set; }

    public string? CodiceOperatore { get; set; }

    public string? CodiceRaccomandata { get; set; }

    public string? IdScatolaArchiviata { get; set; }

    public string? MotivazioneSmarrimento { get; set; }

    public DateTime? DataInsertMonitoring { get; set; }
}

using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class MonitoringBuste
{
    public int IdMonitoringBuste { get; set; }

    public DateTime? Data { get; set; }

    public string Frazionario { get; set; } = null!;

    public string IdControlloBusta { get; set; } = null!;

    public string CodiceOperatoreControllo { get; set; } = null!;

    public string IdBustaOperatore { get; set; } = null!;

    public string CodiceOperatoreBusta { get; set; } = null!;

    public DateTime DataContabile { get; set; }

    public DateTime? DataEsecuzioneControllo { get; set; }

    public string? StatoDa { get; set; }

    public string StatoA { get; set; } = null!;

    public int? EsitoControllo { get; set; }

    public DateTime? DataInsertMonitoring { get; set; }
}

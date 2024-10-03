using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class Ufficio
{
    public string Fraz { get; set; } = null!;

    public string DescUff { get; set; } = null!;

    public string Indi { get; set; } = null!;

    public string? Cap { get; set; }

    public string? CodComu { get; set; }

    public string? CodProv { get; set; }

    public DateOnly DtConfUff { get; set; }

    public DateOnly DtAttivUff { get; set; }

    public DateOnly DtDisaUff { get; set; }

    public short NumMaxPdl { get; set; }

    public short NumPdlRetr { get; set; }

    public string VersSoft { get; set; } = null!;

    public short? CodComt { get; set; }

    public DateTime? DtUltiConf { get; set; }

    public DateOnly? DtUltiChiu { get; set; }

    public short CodTipoUff { get; set; }

    public decimal? LimiGiacUff { get; set; }

    public decimal? LimiSicuUff { get; set; }

    public decimal? DeflLimiGiacCass { get; set; }

    public decimal? DeflLimiSicuCass { get; set; }

    public string? FlTipoLavz { get; set; }

    public string ModaLavoUff { get; set; } = null!;

    public short? BckeCnfg { get; set; }

    public string? Civi { get; set; }

    public string? DescLoca { get; set; }

    public string FlDema { get; set; } = null!;

    public string? CodDettTipoFraz { get; set; }

    public string? DescDettTipoFraz { get; set; }

    public string? CntrCost { get; set; }
}

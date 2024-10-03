using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class Tbcatope
{
    public string CdOpe { get; set; } = null!;

    public string FlExeOffHst { get; set; } = null!;

    public string FlGdf { get; set; } = null!;

    public string? CdOpeAnn { get; set; }

    public string? CdTrxHst { get; set; }

    public string FlCommiss { get; set; } = null!;

    public string FlStampa { get; set; } = null!;

    public string? DlSrvReqAn { get; set; }

    public string FlAnn { get; set; } = null!;

    public string? CdPrcHst { get; set; }

    public decimal NmMaxMultiple { get; set; }

    public string? CdTipOpe { get; set; }

    public string FlObbPresent { get; set; } = null!;

    public string CdSegno { get; set; } = null!;

    public string? CdChiusuraOk { get; set; }

    public string? CdChiusuraKo { get; set; }

    public string? CdHelp { get; set; }

    public string FlDisattivaz { get; set; } = null!;

    public string FlSospens { get; set; } = null!;

    public string? CdTipRegolam { get; set; }

    public string? CdGrpAppartenenz { get; set; }

    public string? CdModSta { get; set; }

    public string? CdTipWin { get; set; }

    public string? CdGrpAr { get; set; }

    public string FlCircolarita { get; set; } = null!;

    public string FlRelCli { get; set; } = null!;

    public string FlAntiric { get; set; } = null!;

    public string FlCauAntiric { get; set; } = null!;

    public string FlMapOut { get; set; } = null!;

    public string FlCauUic { get; set; } = null!;

    public string FlDivRap { get; set; } = null!;

    public string CdBanca { get; set; } = null!;

    public decimal NmElmPag { get; set; }

    public string? PrgHost { get; set; }

    public string CdCanale { get; set; } = null!;

    public string FlAbilitNcass { get; set; } = null!;

    public string? CdOpeVis { get; set; }

    public string? CdOpeVisMenu { get; set; }

    public string FlAntifro { get; set; } = null!;

    public string FlAnntecn { get; set; } = null!;

    public string? CdSotsist { get; set; }

    public string FlagOutp { get; set; } = null!;

    public string FlagDivRapp { get; set; } = null!;

    public string FlagCausUic { get; set; } = null!;

    public string FlagAmmiRist { get; set; } = null!;

    public string FlagLuw { get; set; } = null!;

    public string FlagPrfz { get; set; } = null!;

    public string FlagNumt { get; set; } = null!;

    public string FlagOrac { get; set; } = null!;

    public string FlagStamGior { get; set; } = null!;

    public string FlagRgsaXml { get; set; } = null!;

    public string FlagRtry { get; set; } = null!;

    public string FlagRtryManu { get; set; } = null!;

    public decimal NumRtryAmme { get; set; }

    public string FlTrasFond { get; set; } = null!;

    public string CdStam { get; set; } = null!;

    public string FlLed { get; set; } = null!;

    public string FlStatCont { get; set; } = null!;

    public string FlVeriContProl { get; set; } = null!;

    public string StatCarr { get; set; } = null!;

    public DateOnly DtInizVali { get; set; }

    public DateOnly DtFineVali { get; set; }

    public short VersSoftIniz { get; set; }

    public short VersSoftFine { get; set; }

    public string FlDema { get; set; } = null!;

    public string TipoBanc { get; set; } = null!;
}

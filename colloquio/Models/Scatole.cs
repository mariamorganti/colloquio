using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class Scatole
{
    public string IdScatola { get; set; } = null!;

    public string Frazionario { get; set; } = null!;

    public string CodiceOperatore { get; set; } = null!;

    public string Stato { get; set; } = null!;

    public DateTime DataApertura { get; set; }

    public DateTime? DataChiusura { get; set; }

    public DateTime DataAfferenzaDa { get; set; }

    public DateTime? DataAfferenzaA { get; set; }

    public DateTime? DataInvio { get; set; }

    public string CodiceOperatoreModifica { get; set; } = null!;

    public string? CodiceOperatoreChiusura { get; set; }

    public string? CodiceRaccomandata { get; set; }

    public DateTime DataCreazione { get; set; }

    public DateTime DataModifica { get; set; }

    public DateTime? DataArchiviazione { get; set; }

    public string? IdScatolaMagazzino { get; set; }

    public string? NoteDiSmarrimento { get; set; }
}

using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class StruttureLogistiche
{
    public string Codice { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string CodiceStrutturaParent { get; set; } = null!;

    public string Descrizione { get; set; } = null!;

    public DateTime? DataAbilitazione { get; set; }

    public DateTime DataCreazione { get; set; }
}

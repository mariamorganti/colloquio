using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class AltriFiltri
{
    public int IdAltriFiltri { get; set; }

    public decimal? ImportoComplessivo { get; set; }

    public decimal? ImportoComplessivoDa { get; set; }

    public decimal? ImportoComplessivoA { get; set; }

    public string? Pdl { get; set; }

    public string? UtenzaOperatore { get; set; }

    public string? ProgressivoOperazione { get; set; }

    public int IdRicerca { get; set; }

    public string? FormaTecnica1 { get; set; }

    public virtual RicercheStoriche IdRicercaNavigation { get; set; } = null!;
}

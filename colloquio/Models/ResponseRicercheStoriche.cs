using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class ResponseRicercheStoriche
{
    public int IdResponse { get; set; }

    public string? Scatole { get; set; }

    public string? EventiSc { get; set; }

    public string? BusteBo { get; set; }

    public string? EventiBo { get; set; }

    public string? RicevuteBo { get; set; }

    public string? BusteBb { get; set; }

    public string? EventiBb { get; set; }

    public string? DocumentiBb { get; set; }

    public string? BusteBe { get; set; }

    public string? EventiBe { get; set; }

    public string? RicevuteBe { get; set; }

    public string? Operazioni { get; set; }

    public int IdRicerca { get; set; }

    public virtual RicercheStoriche IdRicercaNavigation { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class TracceHistory
{
    public long CodiceOperazione { get; set; }

    public string Frazionario { get; set; } = null!;

    public DateOnly DataContabile { get; set; }

    public int ProgressivoOperazione { get; set; }

    public string CodiceFase { get; set; } = null!;

    public string TipoOperazione { get; set; } = null!;

    public string CodicePdl { get; set; } = null!;

    public DateTime DataOperazione { get; set; }

    public decimal? Importo { get; set; }

    public string? NumeroCassa { get; set; }

    public string CodiceOperatore { get; set; } = null!;

    public string? ModalitaPagamento { get; set; }

    public string? CodiceFormaTecnica1 { get; set; }

    public string? ValoreFormaTecnica1 { get; set; }

    public string? CodiceFormaTecnica2 { get; set; }

    public string? ValoreFormaTecnica2 { get; set; }

    public string? IdentificativoTransazione { get; set; }

    public string? Metadati { get; set; }

    public string? EsitoDematerializzazione { get; set; }

    public DateTime DataCreazione { get; set; }

    public string? CdStsOpe { get; set; }

    public long? IdOpeCom { get; set; }
}

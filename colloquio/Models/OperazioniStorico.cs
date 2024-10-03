using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class OperazioniStorico
{
    public Guid IdRicevuta { get; set; }

    public string? IdentificativoFiscale { get; set; }

    public string? Frazionario { get; set; }

    public string? NumeroOperazione { get; set; }

    public string? Pdl { get; set; }

    public DateTime? DataOperazione { get; set; }

    public DateOnly? DataContabile { get; set; }

    public string? SottocategoriaFase { get; set; }

    public string? CodiceFase { get; set; }

    public decimal? Importo { get; set; }

    public bool? Annullo { get; set; }

    public bool? Stampa { get; set; }

    public bool? StampaDifferita { get; set; }

    public bool? Riconoscimento { get; set; }

    public DateTime? SysDataInserimento { get; set; }

    public bool? InvioBacheca { get; set; }

    public string? Attributes { get; set; }

    public string? CodiceContabile { get; set; }

    public bool? DeliveredAcarrello { get; set; }

    public bool? DeliveryDifferita { get; set; }

    public bool? DeliveryDigitale { get; set; }

    public string? DescrizioneFase { get; set; }

    public string? IdCarrello { get; set; }

    public bool? InteresseBacheca { get; set; }

    public DateTime DataOraSvecchiamento { get; set; }

    public string? StatoFirma { get; set; }

    public string? NomeFileFirmato { get; set; }

    public string? DataAggStatoFirma { get; set; }
}

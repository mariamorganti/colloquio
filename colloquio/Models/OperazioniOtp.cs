using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class OperazioniOtp
{
    public int SystemId { get; set; }

    public Guid IdRicevuta { get; set; }

    public bool? FlagGenerabilita { get; set; }

    public bool? FlagStampa { get; set; }

    public bool? FlagBruciatura { get; set; }

    public DateTime? DataCreazione { get; set; }

    public string? Password { get; set; }

    public string? Salt { get; set; }

    public DateTime? SysDataInserimento { get; set; }

    public virtual Operazioni IdRicevutaNavigation { get; set; } = null!;
}

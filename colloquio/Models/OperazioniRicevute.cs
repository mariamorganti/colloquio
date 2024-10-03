using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class OperazioniRicevute
{
    public int SystemId { get; set; }

    public Guid IdRicevuta { get; set; }

    public byte[]? File { get; set; }

    public DateTime? SysDataInserimento { get; set; }

    public virtual Operazioni IdRicevutaNavigation { get; set; } = null!;
}

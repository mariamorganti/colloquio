using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class Tbanaope
{
    public string? DsBreve { get; set; }

    public string? DlOgg { get; set; }

    public string CdLing { get; set; } = null!;

    public string CdOpe { get; set; } = null!;

    public DateOnly DtInizVali { get; set; }

    public DateOnly DtFineVali { get; set; }

    public short VersSoftIniz { get; set; }

    public short VersSoftFine { get; set; }
}

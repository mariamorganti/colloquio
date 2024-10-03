using System;
using System.Collections.Generic;

namespace colloquio.Models;

public partial class Glossario
{
    public string Cod { get; set; } = null!;

    public string DescBrev { get; set; } = null!;

    public string? DescEste { get; set; }

    public DateOnly DtInizVali { get; set; }

    public DateOnly DtFineVali { get; set; }

    public short VersSoftIniz { get; set; }

    public short VersSoftFine { get; set; }
}

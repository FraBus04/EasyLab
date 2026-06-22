using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Comm
{
    public long Numgeg { get; set; }

    public string TipoDocumento { get; set; } = null!;

    public byte Column3 { get; set; }

    public byte Column4 { get; set; }

    public byte Column5 { get; set; }

    public short NumeroDoc { get; set; }

    public string Sezinale { get; set; } = null!;

    public short Anno { get; set; }
}

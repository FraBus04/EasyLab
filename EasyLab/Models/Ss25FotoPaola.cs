using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Ss25FotoPaola
{
    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string ModCol { get; set; } = null!;

    public int? IdMod { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdModCol { get; set; }

    public string? Ean { get; set; }

    public int? IdEan { get; set; }
}

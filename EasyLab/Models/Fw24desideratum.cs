using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Fw24desideratum
{
    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string ModCol { get; set; } = null!;

    public short? Tot { get; set; }

    public int? IdSet { get; set; }

    public int? IdMod { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModColNoStag { get; set; }
}

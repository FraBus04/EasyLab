using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MagBo250225
{
    public string Sku { get; set; } = null!;

    public string Tg1 { get; set; } = null!;

    public int Sell { get; set; }

    public int Stock { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ModCol { get; set; }

    public string? Ean { get; set; }

    public string? Tg { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdSet { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? IdSetOrd { get; set; }

    public int? IdEan { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MariaSkuWeb
{
    public string Sku { get; set; } = null!;

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ModCol { get; set; }

    public int? IdModColNoStag { get; set; }
}

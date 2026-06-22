using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Sofia2
{
    public string Seasonality { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string Col { get; set; } = null!;

    public int? IdMod { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdStagionalita { get; set; }

    public int? IdStagionalitaOld { get; set; }
}

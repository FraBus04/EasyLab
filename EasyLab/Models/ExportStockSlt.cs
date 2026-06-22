using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ExportStockSlt
{
    public DateOnly? DataMov { get; set; }

    public string? Attivita { get; set; }

    public string? CdMag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ModCol { get; set; }

    public string? Tg { get; set; }

    public int? Qta { get; set; }

    public int? IdMod { get; set; }

    public int? IdEan { get; set; }

    public int? CkErr { get; set; }

    public int? IndiceTag { get; set; }
}

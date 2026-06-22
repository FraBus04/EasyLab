using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class LauraT7t6
{
    public string Sku { get; set; } = null!;

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string Col { get; set; } = null!;

    public byte? NrT7 { get; set; }

    public string? A { get; set; }

    public string? PrelievoDaT7 { get; set; }

    public byte? NrT6 { get; set; }

    public string? B { get; set; }

    public string? PrelievoDaT6 { get; set; }

    public string? Ean { get; set; }

    public int? IdEan { get; set; }
}

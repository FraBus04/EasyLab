using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BstEan
{
    public long Barcode { get; set; }

    public string ArticoloTse { get; set; } = null!;

    public string ArticoloBs3 { get; set; } = null!;

    public string Diff { get; set; } = null!;

    public string? Column5 { get; set; }

    public int? StockN001 { get; set; }

    public int? StockCh01 { get; set; }

    public int? SbexistOnTse { get; set; }
}

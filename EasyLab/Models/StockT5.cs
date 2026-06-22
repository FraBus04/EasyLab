using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class StockT5
{
    public string? Stock { get; set; }

    public string? Items { get; set; }

    public string? Colors { get; set; }

    public string? Desmod { get; set; }

    public string? Size { get; set; }

    public byte? Stockqty { get; set; }

    public long? Barcode { get; set; }

    public string? CdLinea { get; set; }

    public string? CdStagion { get; set; }

    public string? Defmod { get; set; }

    public byte? Steapp { get; set; }

    public int? ToTapiT5t6 { get; set; }
}

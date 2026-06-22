using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SkuEanStock
{
    public string Ean { get; set; } = null!;

    public int IdContatto { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? CodCol { get; set; }

    public string? Tg { get; set; }

    public string? Sku { get; set; }

    public bool? Enab { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUtil { get; set; }

    public bool? CkExp { get; set; }

    public DateOnly? DataExp { get; set; }

    public int? CkEsiste { get; set; }
}

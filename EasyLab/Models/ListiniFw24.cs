using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ListiniFw24
{
    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ModCol { get; set; }

    public string? Sku { get; set; }

    public short? Whsl { get; set; }

    public short? Rtl { get; set; }

    public int? WhsRow { get; set; }

    public int? RtlRow { get; set; }

    public int? WhsRu { get; set; }

    public int? RtlRu { get; set; }

    public DateOnly? ValidA { get; set; }

    public DateOnly? ValidDa { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Laura
{
    public string Sku { get; set; } = null!;

    public string CodiceModParte { get; set; } = null!;

    public int? Ss23RetPr { get; set; }

    public int? Ss23 { get; set; }

    public int? Fw23RePricingLaura { get; set; }

    public int? Chf { get; set; }

    public int? Gbp { get; set; }

    public int? Usd { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public double? TseretUsd { get; set; }

    public double? TseretChf { get; set; }

    public double? TseretGbp { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ReportListinoControllo
{
    public string Season { get; set; } = null!;

    public string Style { get; set; } = null!;

    public string Fabric { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string CatMercMacroDesc { get; set; } = null!;

    public string CatMercDesc { get; set; } = null!;

    public string? DescCommercMod { get; set; }

    public string? TotVend { get; set; }

    public string? WhsEuro { get; set; }

    public double? Column10 { get; set; }

    public string RetailEuro { get; set; } = null!;

    public double Column12 { get; set; }
}

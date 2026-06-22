using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Listini
{
    public string CodArt { get; set; } = null!;

    public string? Stag { get; set; }

    public DateOnly DataValInizio { get; set; }

    public DateOnly DataValFine { get; set; }

    public double? WhsEuro { get; set; }

    public double RetailEuro { get; set; }

    public double? Gbpxxx { get; set; }

    public double? RetailGbp { get; set; }

    public double? Chfxxx { get; set; }

    public double? RetailChf { get; set; }
}

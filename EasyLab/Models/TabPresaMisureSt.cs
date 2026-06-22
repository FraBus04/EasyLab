using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabPresaMisureSt
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string? Lab { get; set; }

    public string Nome { get; set; } = null!;

    public int IdSt { get; set; }

    public int? OrdPm { get; set; }

    public bool? CkIncAut { get; set; }

    public double? Sc1 { get; set; }

    public double? Sc2 { get; set; }

    public double? Sc3 { get; set; }

    public double? Sc4 { get; set; }

    public double? Sc5 { get; set; }

    public double? Sc6 { get; set; }

    public double? Sc7 { get; set; }

    public double? Sc8 { get; set; }

    public double? Sc9 { get; set; }

    public double? Sc10 { get; set; }

    public double? Sc11 { get; set; }

    public double? Sc12 { get; set; }

    public double? Sc13 { get; set; }

    public double? Sc14 { get; set; }

    public double? Sc15 { get; set; }

    public string? PathImg { get; set; }

    public double? Toll { get; set; }
}

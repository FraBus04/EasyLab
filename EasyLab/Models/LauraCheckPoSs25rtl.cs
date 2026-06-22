using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class LauraCheckPoSs25rtl
{
    public string StoreLocation { get; set; } = null!;

    public string Retailer { get; set; } = null!;

    public string Po { get; set; } = null!;

    public short CustomerCode { get; set; }

    public string PriceLabel { get; set; } = null!;

    public short Units { get; set; }

    public double TotWhl { get; set; }

    public string OrderType { get; set; } = null!;

    public string CheckPlm { get; set; } = null!;

    public int? CapiLordi { get; set; }

    public int? CapiLordiAnn { get; set; }

    public int? CapiNetti { get; set; }

    public int? CapiNettiR { get; set; }

    public int? CapiNettiL { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BiAnalisiVendutiRetail
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public string TipoDato { get; set; } = null!;

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public DateOnly? DataMov { get; set; }

    public int? Nr1 { get; set; }

    public int? Nr2 { get; set; }

    public int? Nr3 { get; set; }

    public int? Nr4 { get; set; }

    public int? Nr5 { get; set; }

    public int? Nr6 { get; set; }

    public int? Nr7 { get; set; }

    public int? Nr8 { get; set; }

    public int? Nr9 { get; set; }

    public int? Nr10 { get; set; }

    public int? Nr11 { get; set; }

    public int? Nr12 { get; set; }

    public int? Nr13 { get; set; }

    public int? Nr14 { get; set; }

    public int? Nr15 { get; set; }

    public int? Nr16 { get; set; }

    public int? Nr17 { get; set; }

    public int? Nr18 { get; set; }

    public int? Nr19 { get; set; }

    public int? Nr20 { get; set; }

    public int? TotCapi { get; set; }

    public double? Val1 { get; set; }

    public double? Val2 { get; set; }

    public double? Val3 { get; set; }

    public double? Val4 { get; set; }

    public double? Val5 { get; set; }

    public double? Val6 { get; set; }

    public double? Val7 { get; set; }

    public double? Val8 { get; set; }

    public double? Val9 { get; set; }

    public double? Val10 { get; set; }

    public double? Val11 { get; set; }

    public double? Val12 { get; set; }

    public double? Val13 { get; set; }

    public double? Val14 { get; set; }

    public double? Val15 { get; set; }

    public double? Val16 { get; set; }

    public double? Val17 { get; set; }

    public double? Val18 { get; set; }

    public double? Val19 { get; set; }

    public double? Val20 { get; set; }

    public double? TotVal { get; set; }

    public DateTime? DataIns { get; set; }

    public string? CodMag { get; set; }

    public int? IdCausale { get; set; }

    public DateOnly? DataDa { get; set; }

    public DateOnly? DataA { get; set; }

    public int? CarTotCapiCatMercMacro { get; set; }

    public int? CarTotCapiCatMerc { get; set; }

    public int? CarTotCapiMod { get; set; }

    public int? CarTotCapiProd { get; set; }

    public int? CarTotCapiModCol { get; set; }

    public int? VenTotCapiCatMercMacro { get; set; }

    public int? VenTotCapiCatMerc { get; set; }

    public int? VenTotCapiMod { get; set; }

    public int? VenTotCapiProd { get; set; }

    public int? VenTotCapiModCol { get; set; }

    public int? IdCatMerc { get; set; }

    public string? Mod { get; set; }

    public double? PercTotCapiCatMercMacro { get; set; }

    public double? PercTotCapiCatMerc { get; set; }

    public double? PercTotCapiMod { get; set; }

    public double? PercTotCapiProd { get; set; }

    public double? PercTotCapiModCol { get; set; }
}

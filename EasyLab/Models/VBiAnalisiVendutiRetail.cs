using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBiAnalisiVendutiRetail
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public string TipoDato { get; set; } = null!;

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public string? Stag { get; set; }

    public string? TipoModello { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public string? Nome { get; set; }

    public string? GenderCod { get; set; }

    public string? CatMercDesc { get; set; }

    public int? CatMercOrdPm { get; set; }

    public string? PathImgMod { get; set; }

    public string? Tg1 { get; set; }

    public string? Tg2 { get; set; }

    public string? Tg3 { get; set; }

    public string? Tg4 { get; set; }

    public string? Tg5 { get; set; }

    public string? Tg6 { get; set; }

    public string? Tg7 { get; set; }

    public string? Tg8 { get; set; }

    public string? Tg9 { get; set; }

    public string? Tg10 { get; set; }

    public string? Tg11 { get; set; }

    public string? PathImgCol { get; set; }

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

    public int? TotCapi { get; set; }

    public string? CodMag { get; set; }

    public DateOnly? DataDa { get; set; }

    public DateOnly? DataA { get; set; }

    public int? IdCatMerc { get; set; }

    public int? IdCatMercMacro { get; set; }

    public string? CatMercMacroDesc { get; set; }

    public int? CatMercMacroOrdPm { get; set; }

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

    public double? PercTotCapiCatMercMacro { get; set; }

    public double? PercTotCapiCatMerc { get; set; }

    public double? PercTotCapiMod { get; set; }

    public double? PercTotCapiProd { get; set; }

    public double? PercTotCapiModCol { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBiAnalisiVendutiLineSheet
{
    public int Id { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public int? IdLista { get; set; }

    public string? ListaCod { get; set; }

    public string? ListaNome { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public int? IdKey { get; set; }

    public int IdVista { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public int? IdRigaOrd { get; set; }

    public int? Tot0 { get; set; }

    public int? Tot5 { get; set; }

    public int? Tot6 { get; set; }

    public int? Tot7 { get; set; }

    public string? CatMercMacroCod { get; set; }

    public string? CatMercMacroDesc { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public double? List1 { get; set; }

    public double? List2 { get; set; }

    public double? List3 { get; set; }

    public int? IdSetTaglia { get; set; }

    public string? DescCommerc { get; set; }

    public int? Nr015 { get; set; }

    public bool? CkModCol { get; set; }

    public int? TotVendCapi { get; set; }

    public double? TotVendVal { get; set; }

    public int? TotNettoCapi { get; set; }

    public double? TotNettoVal { get; set; }

    public int? TotNettoCapiL { get; set; }

    public double? TotNettoValL { get; set; }

    public int? TotNettoCapiR { get; set; }

    public double? TotNettoValR { get; set; }

    public byte[]? ImmagineMod { get; set; }

    public byte[]? ImmagineModCol { get; set; }

    public double? Val5 { get; set; }

    public double? Val6 { get; set; }

    public double? Val7 { get; set; }

    public int? IdCanale { get; set; }

    public string? CanaleCod { get; set; }

    public string? CanaleDesc { get; set; }
}

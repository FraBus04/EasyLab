using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VAnalisiProdottiStato
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public int? Vista { get; set; }

    public int IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public string? Stag { get; set; }

    public int? IdCanale { get; set; }

    public string? Canale { get; set; }

    public string? StatoMod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? CatMercMacro { get; set; }

    public string? CatMerc { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public int? TotVendLordo { get; set; }

    public int? TotVendNetto { get; set; }

    public int? TotRnetto { get; set; }

    public int? TotLnetto { get; set; }

    public int? TotRdaAss { get; set; }

    public int? TotDaLanc { get; set; }

    public int? TotInLav { get; set; }

    public int? TotInMag { get; set; }

    public int? TotSped { get; set; }

    public int? TotAnn { get; set; }

    public double? ValTotVendLordo { get; set; }

    public double? ValTotVendNetto { get; set; }

    public double? ValTotRnetto { get; set; }

    public double? ValTotLnetto { get; set; }

    public double? ValTotRdaAss { get; set; }

    public double? ValTotDaLanc { get; set; }

    public double? ValTotInLav { get; set; }

    public double? ValTotInMag { get; set; }

    public double? ValTotSped { get; set; }

    public double? ValTotAnn { get; set; }

    public DateTime? DataIns { get; set; }

    public int? IdUte { get; set; }
}

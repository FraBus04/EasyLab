using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VCollPlanItem
{
    public int Id { get; set; }

    public int IdCollTesta { get; set; }

    public int IdCollGroup { get; set; }

    public int IdMod { get; set; }

    public int? IdModCol { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }

    public string? CatMercMacro { get; set; }

    public string? CatMercMacro2 { get; set; }

    public string? CatMerc { get; set; }

    public string? CatMerc2 { get; set; }

    public string? Contatto { get; set; }

    public string? Stag { get; set; }

    public string? CollPlanCod { get; set; }

    public string? CollPlanDescr { get; set; }

    public int? IdStag { get; set; }

    public int? Qta { get; set; }

    public int? PrzDa { get; set; }

    public int? PrzA { get; set; }

    public string? StagMod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public int? IdCol { get; set; }

    public int? IdModColCosto { get; set; }

    public decimal? TotFasi { get; set; }

    public decimal? TotMatT { get; set; }

    public decimal? TotMatC { get; set; }

    public decimal? TotMatS { get; set; }

    public decimal? TotMatL { get; set; }

    public decimal? TotImp { get; set; }

    public decimal? PercAddCosti { get; set; }

    public decimal? TotCostoFisso { get; set; }

    public decimal? MarkUpIni { get; set; }

    public string? Nota { get; set; }

    public string? StatoAppProd { get; set; }

    public string? StatoAppCol { get; set; }

    public int? IdAvanzMod { get; set; }

    public string? AvanzMod { get; set; }

    public int? AvanzModPerc { get; set; }

    public string? TipoModello { get; set; }

    public int? IdCatMercMacro { get; set; }

    public int? IdCatMerc { get; set; }

    public int? IdCatMercMacro2 { get; set; }

    public int? IdCatMerc2 { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiModelliAvanzSchedaCosto
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdMod { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? Linea { get; set; }

    public string? LineaDesc { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public int? IdAvanzMod { get; set; }

    public string? AvanzMod { get; set; }

    public double? TotFasi { get; set; }

    public double? TotMatT { get; set; }

    public double? TotMatC { get; set; }

    public double? TotMatL { get; set; }

    public double? TotMatS { get; set; }

    public double? TotMatAltre { get; set; }

    public double? TotCostoFisso { get; set; }

    public double? Perc { get; set; }

    public double? TotCostoPerc { get; set; }

    public double? TotCosti { get; set; }

    public double? MarkUpIni { get; set; }

    public double? MarkUpEff { get; set; }

    public string? Contatto { get; set; }

    public string? NotaMod { get; set; }

    public string? TagliaDa { get; set; }

    public string? TagliaA { get; set; }

    public string? TipoSk { get; set; }

    public string? TipoSkdesc { get; set; }

    public string? PathImgMod { get; set; }

    public double? TotCostoNetto { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? StatoApp { get; set; }

    public string? StatoAppCod { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SchedaCostoColoreTestum
{
    public int Id { get; set; }

    public int IdTesta { get; set; }

    public int IdContatto { get; set; }

    public int IdTipoSk { get; set; }

    public string Stato { get; set; } = null!;

    public int IdModCol { get; set; }

    public int IdMod { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public string? Nome { get; set; }

    public string? Linea { get; set; }

    public string? LineaDesc { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

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

    public double? TotCosti2 { get; set; }

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

    public int? IdUteIns { get; set; }

    public string? FaseComm { get; set; }

    public string? FaseBol { get; set; }

    public double? TotComm { get; set; }

    public int? TotCapi { get; set; }

    public double? List1 { get; set; }

    public double? TotMatT2 { get; set; }

    public double? TotMatC2 { get; set; }

    public double? TotFasi2 { get; set; }

    public int? TotCapiProd { get; set; }

    public bool? CkSk { get; set; }

    public string? StatoExp { get; set; }

    public string? StatoApp { get; set; }
}

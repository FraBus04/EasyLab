using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SchedaCostoTestaColore
{
    public int IdTesta { get; set; }

    public int IdContatto { get; set; }

    public int IdTipoSk { get; set; }

    public string Stato { get; set; } = null!;

    public int IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public string? Linea { get; set; }

    public string? LineaDesc { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public double TotFasi { get; set; }

    public double TotMatT { get; set; }

    public double TotMatC { get; set; }

    public double TotMatS { get; set; }

    public double TotMatL { get; set; }

    public double TotMatAltre { get; set; }

    public double TotCostoFisso { get; set; }

    public double Perc { get; set; }

    public double TotCostoPerc { get; set; }

    public double TotCosti { get; set; }

    public double? MarkUpIni { get; set; }

    public double? MarkUpEff { get; set; }

    public string? Contatto { get; set; }

    public string? NotaMod { get; set; }

    public string? TagliaDa { get; set; }

    public string? TagliaA { get; set; }

    public string? TipoSk { get; set; }

    public string? TipoSkdesc { get; set; }

    public string? PathImgMod { get; set; }

    public double TotCostoNetto { get; set; }

    public int? IdColProd1 { get; set; }

    public int? IdColProd2 { get; set; }

    public int? IdColProd3 { get; set; }

    public int? IdColProd4 { get; set; }

    public int? IdColProd5 { get; set; }

    public int? IdColProd6 { get; set; }

    public int? IdColProd7 { get; set; }

    public int? IdColProd8 { get; set; }

    public int? IdColProd9 { get; set; }

    public int? IdColProd10 { get; set; }

    public int? IdColProd11 { get; set; }

    public int? IdColProd12 { get; set; }

    public int? IdColProd13 { get; set; }

    public int? IdColProd14 { get; set; }

    public int? IdColProd15 { get; set; }

    public string? ColCodProd1 { get; set; }

    public string? ColCodProd2 { get; set; }

    public string? ColCodProd3 { get; set; }

    public string? ColCodProd4 { get; set; }

    public string? ColCodProd5 { get; set; }

    public string? ColCodProd6 { get; set; }

    public string? ColCodProd7 { get; set; }

    public string? ColCodProd8 { get; set; }

    public string? ColCodProd9 { get; set; }

    public string? ColCodProd10 { get; set; }

    public string? ColCodProd11 { get; set; }

    public string? ColCodProd12 { get; set; }

    public string? ColCodProd13 { get; set; }

    public string? ColCodProd14 { get; set; }

    public string? ColCodProd15 { get; set; }

    public string? ColDescProd1 { get; set; }

    public string? ColDescProd2 { get; set; }

    public string? ColDescProd3 { get; set; }

    public string? ColDescProd4 { get; set; }

    public string? ColDescProd5 { get; set; }

    public string? ColDescProd6 { get; set; }

    public string? ColDescProd7 { get; set; }

    public string? ColDescProd8 { get; set; }

    public string? ColDescProd9 { get; set; }

    public string? ColDescProd10 { get; set; }

    public string? ColDescProd11 { get; set; }

    public string? ColDescProd12 { get; set; }

    public string? ColDescProd13 { get; set; }

    public string? ColDescProd14 { get; set; }

    public string? ColDescProd15 { get; set; }

    public double? PercAddCosti { get; set; }

    public double? TargetP { get; set; }

    public double? Proposto { get; set; }

    public string? StatoApp { get; set; }

    public string? StatoAppDesc { get; set; }

    public string? FornPref { get; set; }

    public string? LabPrev { get; set; }
}

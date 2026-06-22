using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VSchedaCostoTestum
{
    public int IdTesta { get; set; }

    public int IdContatto { get; set; }

    public int IdTipoSk { get; set; }

    public string Stato { get; set; } = null!;

    public string? ACdAll { get; set; }

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

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public decimal TotFasi { get; set; }

    public decimal TotMatT { get; set; }

    public decimal TotMatC { get; set; }

    public decimal TotMatS { get; set; }

    public decimal TotMatL { get; set; }

    public decimal TotMatAltre { get; set; }

    public decimal TotCostoFisso { get; set; }

    public decimal Perc { get; set; }

    public decimal TotCostoPerc { get; set; }

    public decimal TotCosti { get; set; }

    public decimal? MarkUpIni { get; set; }

    public decimal? MarkUpEff { get; set; }

    public string? Contatto { get; set; }

    public string? NotaMod { get; set; }

    public string? TagliaDa { get; set; }

    public string? TagliaA { get; set; }

    public string? TipoSk { get; set; }

    public string? TipoSkdesc { get; set; }

    public string? TipoSkTipoCalcolo { get; set; }

    public string? PathImgMod { get; set; }

    public decimal? TotCostoNetto { get; set; }

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

    public int? IdColProd16 { get; set; }

    public int? IdColProd17 { get; set; }

    public int? IdColProd18 { get; set; }

    public int? IdColProd19 { get; set; }

    public int? IdColProd20 { get; set; }

    public string ColCodProd1 { get; set; } = null!;

    public string ColCodProd2 { get; set; } = null!;

    public string ColCodProd3 { get; set; } = null!;

    public string ColCodProd4 { get; set; } = null!;

    public string ColCodProd5 { get; set; } = null!;

    public string ColCodProd6 { get; set; } = null!;

    public string ColCodProd7 { get; set; } = null!;

    public string ColCodProd8 { get; set; } = null!;

    public string ColCodProd9 { get; set; } = null!;

    public string ColCodProd10 { get; set; } = null!;

    public string ColCodProd11 { get; set; } = null!;

    public string ColCodProd12 { get; set; } = null!;

    public string ColCodProd13 { get; set; } = null!;

    public string ColCodProd14 { get; set; } = null!;

    public string ColCodProd15 { get; set; } = null!;

    public string ColCodProd16 { get; set; } = null!;

    public string ColCodProd17 { get; set; } = null!;

    public string ColCodProd18 { get; set; } = null!;

    public string ColCodProd19 { get; set; } = null!;

    public string ColCodProd20 { get; set; } = null!;

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

    public string? ColDescProd16 { get; set; }

    public string? ColDescProd17 { get; set; }

    public string? ColDescProd18 { get; set; }

    public string? ColDescProd19 { get; set; }

    public string? ColDescProd20 { get; set; }

    public decimal? PercAddCosti { get; set; }

    public decimal? TargetP { get; set; }

    public decimal? Proposto { get; set; }

    public string? StatoApp { get; set; }

    public string? StatoAppDesc { get; set; }

    public bool? Lock { get; set; }

    public string? FornPref { get; set; }

    public string? LabPrev { get; set; }

    public int? IdSet { get; set; }

    public string? GroupLabel1 { get; set; }

    public string? GroupLabel2 { get; set; }

    public string? GroupLabel3 { get; set; }

    public string? GroupLabel4 { get; set; }

    public decimal? ImpGroup1 { get; set; }

    public decimal? ImpGroup2 { get; set; }

    public decimal? ImpGroup3 { get; set; }

    public decimal? ImpGroup4 { get; set; }

    public decimal? PropGroup1 { get; set; }

    public decimal? PropGroup2 { get; set; }

    public decimal? PropGroup3 { get; set; }

    public decimal? PropGroup4 { get; set; }

    public string? ColSchedaRif { get; set; }

    public decimal? Appr { get; set; }

    public decimal? ApprGroup1 { get; set; }

    public decimal? ApprGroup2 { get; set; }

    public decimal? ApprGroup3 { get; set; }

    public decimal? ApprGroup4 { get; set; }

    public int? IdColSchedaRif { get; set; }

    public DateTime? DataExp { get; set; }

    public string? StatoExp { get; set; }
}

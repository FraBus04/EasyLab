using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SchedaCostoTestum
{
    public int IdTesta { get; set; }

    public int IdContatto { get; set; }

    public int IdTipoSk { get; set; }

    public string Stato { get; set; } = null!;

    public int IdMod { get; set; }

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

    public int? IdSetTgGroup1 { get; set; }

    public int? IdSetTgGroup2 { get; set; }

    public int? IdSetTgGroup3 { get; set; }

    public int? IdSetTgGroup4 { get; set; }

    public int? IdSetPosGroup1 { get; set; }

    public int? IdSetPosGroup2 { get; set; }

    public int? IdSetPosGroup3 { get; set; }

    public int? IdSetPosGroup4 { get; set; }

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

    public decimal? PercAddCosti { get; set; }

    public decimal? TargetP { get; set; }

    public decimal? Proposto { get; set; }

    public int? IdColSchedaRif { get; set; }

    public bool? Lock { get; set; }

    public string? StatoApp { get; set; }

    public int? IdUteStatoApp { get; set; }

    public DateTime? DataApp { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataExp { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? ColSchedaRif { get; set; }

    public decimal? Appr { get; set; }

    public decimal? ApprGroup1 { get; set; }

    public decimal? ApprGroup2 { get; set; }

    public decimal? ApprGroup3 { get; set; }

    public decimal? ApprGroup4 { get; set; }

    public int? IdTipoCalcolo { get; set; }

    public string? ACdAll { get; set; }

    public int? IdColProd16 { get; set; }

    public int? IdColProd17 { get; set; }

    public int? IdColProd18 { get; set; }

    public int? IdColProd19 { get; set; }

    public int? IdColProd20 { get; set; }
}

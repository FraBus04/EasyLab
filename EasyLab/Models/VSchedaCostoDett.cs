using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VSchedaCostoDett
{
    public int Id { get; set; }

    public int IdTesta { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public int? IdTipoSk { get; set; }

    public string? TipoSkcod { get; set; }

    public string? TipoSkdescr { get; set; }

    public string? StatoSk { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public int? IdMod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public decimal? TotFasi { get; set; }

    public decimal? TotMatT { get; set; }

    public decimal? TotMatC { get; set; }

    public decimal? TotMatS { get; set; }

    public decimal? TotMatL { get; set; }

    public decimal? TotMatAltre { get; set; }

    public decimal? TotCostoFisso { get; set; }

    public decimal? Perc { get; set; }

    public decimal? TotCostoPerc { get; set; }

    public decimal? TotCosti { get; set; }

    public string MatLav { get; set; } = null!;

    public short? OrdPm { get; set; }

    public string? MatOper { get; set; }

    public string Tp { get; set; } = null!;

    public string? Tp2 { get; set; }

    public decimal CostoUnit { get; set; }

    public decimal Cons1 { get; set; }

    public decimal Imp1 { get; set; }

    public string? Posizione { get; set; }

    public string? Note { get; set; }

    public int? IdFase { get; set; }

    public int? IdLab { get; set; }

    public string? Lab { get; set; }

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

    public decimal? Imp2 { get; set; }

    public decimal? Imp3 { get; set; }

    public decimal? Imp4 { get; set; }

    public decimal? Imp5 { get; set; }

    public decimal? Imp6 { get; set; }

    public decimal? Imp7 { get; set; }

    public decimal? Imp8 { get; set; }

    public decimal? Imp9 { get; set; }

    public decimal? Imp10 { get; set; }

    public decimal? Imp11 { get; set; }

    public decimal? Imp12 { get; set; }

    public decimal? Imp13 { get; set; }

    public decimal? Imp14 { get; set; }

    public decimal? Imp15 { get; set; }

    public int? IdBomReticolo { get; set; }

    public decimal? Imp { get; set; }

    public bool? CkMrp { get; set; }

    public bool? CkCosto { get; set; }

    public string? DescMat { get; set; }

    public int? IdMat { get; set; }

    public bool? CkMatMis { get; set; }

    public int? IdMatMis { get; set; }

    public decimal? Cons { get; set; }

    public decimal? Cons2 { get; set; }

    public decimal? Cons3 { get; set; }

    public decimal? Cons4 { get; set; }

    public decimal? Cons5 { get; set; }

    public decimal? Cons6 { get; set; }

    public decimal? Cons7 { get; set; }

    public decimal? Cons8 { get; set; }

    public decimal? Cons9 { get; set; }

    public decimal? Cons10 { get; set; }

    public decimal? Cons11 { get; set; }

    public decimal? Cons12 { get; set; }

    public decimal? Cons13 { get; set; }

    public decimal? Cons14 { get; set; }

    public decimal? Cons15 { get; set; }

    public string? Um { get; set; }
}

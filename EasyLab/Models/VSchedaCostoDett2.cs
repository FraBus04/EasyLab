using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VSchedaCostoDett2
{
    public int? IdTesta { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public int? IdTipoSk { get; set; }

    public string? TipoSkcod { get; set; }

    public string? TipoSkdesc { get; set; }

    public string? Stato { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? Linea { get; set; }

    public string? LineaDesc { get; set; }

    public string? TagliaDa { get; set; }

    public string? TagliaA { get; set; }

    public string? TagliaBase { get; set; }

    public string? Nota { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public string? PathImgMod { get; set; }

    public DateTime? DataCreazioneSk { get; set; }

    public string? MatLav { get; set; }

    public short? OrdPm { get; set; }

    public string? MatOper { get; set; }

    public string? Tp { get; set; }

    public string? Tp2 { get; set; }

    public double CostoUnit { get; set; }

    public double Cons1 { get; set; }

    public double Imp1 { get; set; }

    public string? Posizione { get; set; }

    public string? Note { get; set; }

    public string? DescMat { get; set; }

    public string? Fornitore { get; set; }

    public string? CodArtFornitore { get; set; }

    public string? Um { get; set; }

    public string? FaseCod { get; set; }

    public string? FaseDesc { get; set; }

    public string? FaseLab { get; set; }

    public double? TotFasi { get; set; }

    public double? TotMatT { get; set; }

    public double? TotMatC { get; set; }

    public double? TotMatN { get; set; }

    public double? TotMatL { get; set; }

    public double? Pezzi { get; set; }

    public double? MtTape { get; set; }

    public double? Param1 { get; set; }

    public double? Param2 { get; set; }

    public double? Param3 { get; set; }

    public double? Param4 { get; set; }

    public double? Param5 { get; set; }

    public double? Costo1 { get; set; }

    public double? Costo2 { get; set; }

    public double? Costo3 { get; set; }

    public double? Correz1 { get; set; }

    public double? Correz2 { get; set; }

    public bool? CkMadre { get; set; }

    public int? IdContattoMat { get; set; }

    public string? Misura { get; set; }
}

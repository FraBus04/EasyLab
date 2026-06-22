using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VSchedaCostoTemp
{
    public int Id { get; set; }

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

    public string? Modellista { get; set; }

    public string? Composizione { get; set; }

    public string MatLav { get; set; } = null!;

    public short? OrdPm { get; set; }

    public string? MatOper { get; set; }

    public string Tp { get; set; } = null!;

    public string? Tpdesc { get; set; }

    public string? Tp2 { get; set; }

    public double CostoUnit { get; set; }

    public double? Cons { get; set; }

    public double? Imp { get; set; }

    public string? Posizione { get; set; }

    public string? Note { get; set; }

    public string? DescMat { get; set; }

    public string? Fornitore { get; set; }

    public string? CodArtFornitore { get; set; }

    public string? Um { get; set; }

    public string? FaseCod { get; set; }

    public string? FaseDesc { get; set; }

    public string? FaseLab { get; set; }

    public double Imp1 { get; set; }

    public double? Imp2 { get; set; }

    public double? Imp3 { get; set; }

    public double? Imp4 { get; set; }

    public double? Imp5 { get; set; }

    public double? Imp6 { get; set; }

    public double? Imp7 { get; set; }

    public double? Imp8 { get; set; }

    public double? Imp9 { get; set; }

    public double? Imp10 { get; set; }

    public double? Imp11 { get; set; }

    public double? Imp12 { get; set; }

    public double? Imp13 { get; set; }

    public double? Imp14 { get; set; }

    public double? Imp15 { get; set; }

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

    public bool? CkMrp { get; set; }

    public bool? CkCosto { get; set; }

    public int? IdMat { get; set; }

    public double Cons1 { get; set; }

    public double? Cons2 { get; set; }

    public double? Cons3 { get; set; }

    public double? Cons4 { get; set; }

    public double? Cons5 { get; set; }

    public double? Cons6 { get; set; }

    public double? Cons7 { get; set; }

    public double? Cons8 { get; set; }

    public double? Cons9 { get; set; }

    public double? Cons10 { get; set; }

    public double? Cons11 { get; set; }

    public double? Cons12 { get; set; }

    public double? Cons13 { get; set; }

    public double? Cons14 { get; set; }

    public double? Cons15 { get; set; }

    public int? IdSetTgGroup1 { get; set; }

    public int? IdSetTgGroup2 { get; set; }

    public int? IdSetTgGroup3 { get; set; }

    public int? IdSetTgGroup4 { get; set; }

    public int? IdSetPosGroup1 { get; set; }

    public int? IdSetPosGroup2 { get; set; }

    public int? IdSetPosGroup3 { get; set; }

    public int? IdSetPosGroup4 { get; set; }

    public string? SetGroupLab1 { get; set; }

    public string? SetGroupLab2 { get; set; }

    public string? SetGroupLab3 { get; set; }

    public string? SetGroupLab4 { get; set; }

    public double? ConsGroup1 { get; set; }

    public double? ConsGroup2 { get; set; }

    public double? ConsGroup3 { get; set; }

    public double? ConsGroup4 { get; set; }

    public double? ImpGroup1 { get; set; }

    public double? ImpGroup2 { get; set; }

    public double? ImpGroup3 { get; set; }

    public double? ImpGroup4 { get; set; }

    public DateTime? DataIns { get; set; }

    public int IdMod { get; set; }

    public int? IdUteIns { get; set; }

    public string? Expr1 { get; set; }

    public string? Expr2 { get; set; }

    public string? Expr3 { get; set; }

    public string? Expr4 { get; set; }

    public string? Expr5 { get; set; }

    public string? Expr6 { get; set; }

    public string? Expr7 { get; set; }

    public string? Expr8 { get; set; }

    public string? Expr9 { get; set; }

    public string? Expr10 { get; set; }

    public string? Expr11 { get; set; }

    public string? Expr12 { get; set; }

    public string? Expr13 { get; set; }

    public string? Expr14 { get; set; }

    public string? Expr15 { get; set; }

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
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VSchedaCosto
{
    public int Id { get; set; }

    public int? IdTesta { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public int? IdTipoSk { get; set; }

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

    public string? Modellista { get; set; }

    public string? Composizione { get; set; }

    public DateTime? DataCreazioneSk { get; set; }

    public string MatLav { get; set; } = null!;

    public short? OrdPm { get; set; }

    public string? MatOper { get; set; }

    public string Tp { get; set; } = null!;

    public string? Tpdesc { get; set; }

    public string? Tp2 { get; set; }

    public decimal CostoUnit { get; set; }

    public decimal? Cons { get; set; }

    public decimal? Imp { get; set; }

    public string? Posizione { get; set; }

    public string? Note { get; set; }

    public string? DescMat { get; set; }

    public string? Fornitore { get; set; }

    public string? CodArtFornitore { get; set; }

    public string? Um { get; set; }

    public string? FaseCod { get; set; }

    public string? FaseDesc { get; set; }

    public string? FaseLab { get; set; }

    public decimal? TotFasi { get; set; }

    public decimal? TotMatT { get; set; }

    public decimal? TotMatC { get; set; }

    public decimal? TotMatL { get; set; }

    public decimal? TotMatS { get; set; }

    public decimal? TotMatAltre { get; set; }

    public decimal? TotCostoPerc { get; set; }

    public decimal? TotCostoFisso { get; set; }

    public decimal? Perc { get; set; }

    public decimal? TotCosti { get; set; }

    public decimal? MarkUpIni { get; set; }

    public decimal Imp1 { get; set; }

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

    public decimal? Imp16 { get; set; }

    public decimal? Imp17 { get; set; }

    public decimal? Imp18 { get; set; }

    public decimal? Imp19 { get; set; }

    public decimal? Imp20 { get; set; }

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

    public string? ColCodProd16 { get; set; }

    public string? ColCodProd17 { get; set; }

    public string? ColCodProd18 { get; set; }

    public string? ColCodProd19 { get; set; }

    public string? ColCodProd20 { get; set; }

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

    public bool? CkMrp { get; set; }

    public bool? CkCosto { get; set; }

    public int? IdMat { get; set; }

    public decimal? PercAddCosti { get; set; }

    public string? TipoSk { get; set; }

    public string? TipoSkdesc { get; set; }

    public decimal Cons1 { get; set; }

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

    public decimal? Cons16 { get; set; }

    public int? IdColSchedaRif { get; set; }

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

    public decimal? TargetP { get; set; }

    public decimal? Proposto { get; set; }

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

    public decimal? ConsGroup1 { get; set; }

    public decimal? ConsGroup2 { get; set; }

    public decimal? ConsGroup3 { get; set; }

    public decimal? ConsGroup4 { get; set; }

    public decimal? ImpGroup1 { get; set; }

    public decimal? ImpGroup2 { get; set; }

    public decimal? ImpGroup3 { get; set; }

    public decimal? ImpGroup4 { get; set; }

    public int? IdMod { get; set; }

    public string? StatoApp { get; set; }

    public decimal? ImpTg1 { get; set; }

    public decimal? ImpTg2 { get; set; }

    public decimal? ImpTg3 { get; set; }

    public decimal? ImpTg4 { get; set; }

    public decimal? ImpTg5 { get; set; }

    public decimal? ImpTg6 { get; set; }

    public decimal? ImpTg7 { get; set; }

    public decimal? ImpTg8 { get; set; }

    public decimal? ImpTg9 { get; set; }

    public decimal? ImpTg10 { get; set; }

    public decimal? ImpTg11 { get; set; }

    public decimal? ImpTg12 { get; set; }

    public decimal? ImpTg13 { get; set; }

    public decimal? ImpTg14 { get; set; }

    public decimal? ImpTg15 { get; set; }

    public decimal? ImpTg16 { get; set; }

    public string? BCdAllcol1 { get; set; }

    public string? BCdAllcol2 { get; set; }

    public string? BCdAllcol3 { get; set; }

    public string? BCdAllcol4 { get; set; }

    public string? BCdAllcol5 { get; set; }

    public string? BCdAllcol6 { get; set; }

    public string? BCdAllcol7 { get; set; }

    public string? BCdAllcol8 { get; set; }

    public string? BCdAllcol9 { get; set; }

    public string? BCdAllcol10 { get; set; }

    public string? BCdAllcol11 { get; set; }

    public string? BCdAllcol12 { get; set; }

    public string? BCdAllcol13 { get; set; }

    public string? BCdAllcol14 { get; set; }

    public string? BCdAllcol15 { get; set; }

    public string? BCdAllcol16 { get; set; }

    public string? BCdAllcol17 { get; set; }

    public string? BCdAllcol18 { get; set; }

    public string? BCdAllcol19 { get; set; }

    public string? BCdAllcol20 { get; set; }

    public bool? CkCons1 { get; set; }

    public bool? CkCons2 { get; set; }

    public bool? CkCons3 { get; set; }

    public bool? CkCons4 { get; set; }

    public bool? CkCons5 { get; set; }

    public bool? CkCons6 { get; set; }

    public bool? CkCons7 { get; set; }

    public bool? CkCons8 { get; set; }

    public bool? CkCons9 { get; set; }

    public bool? CkCons10 { get; set; }

    public bool? CkCons11 { get; set; }

    public bool? CkCons12 { get; set; }

    public bool? CkCons13 { get; set; }

    public bool? CkCons14 { get; set; }

    public bool? CkCons15 { get; set; }

    public bool? CkCons16 { get; set; }

    public string? BCdAllcolRif { get; set; }

    public int? OrdPmPm { get; set; }
}

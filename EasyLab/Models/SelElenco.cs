using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SelElenco
{
    public string? Stato { get; set; }

    public string? CdAll { get; set; }

    public int? IdUte { get; set; }

    public string? Tipo { get; set; }

    public int? Id { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? Cad { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? IdTagliaBase { get; set; }

    public int? IdTagliaDa { get; set; }

    public int? IdTagliaA { get; set; }

    public string? Tg { get; set; }

    public string? AvanzMod { get; set; }

    public string? TipoModello { get; set; }

    public int? IdComp { get; set; }

    public string? Composizione { get; set; }

    public string? Comp2 { get; set; }

    public string? Comp3 { get; set; }

    public string? Comp4 { get; set; }

    public string? Comp5 { get; set; }

    public string? Pos1 { get; set; }

    public string? Pos2 { get; set; }

    public string? Pos3 { get; set; }

    public string? Pos4 { get; set; }

    public string? Pos5 { get; set; }

    public string? Nota { get; set; }

    public string? PathImg { get; set; }

    public bool? CkModello { get; set; }

    public string? NotaCostruz { get; set; }

    public string? CatMerc { get; set; }

    public string? CodSetTg { get; set; }

    public string? DescSetTg { get; set; }

    public string? Linea { get; set; }

    public string? LineaDesc { get; set; }

    public int? IdCatMerc { get; set; }

    public string? Trattamento { get; set; }

    public string? TipoPunto { get; set; }

    public string? BaseProv { get; set; }

    public string? Modellista { get; set; }

    public string? TipoFilatoCucit { get; set; }

    public string? TipoFilatoImp { get; set; }

    public double? Listino { get; set; }

    public string? Tg1 { get; set; }

    public string? Tg2 { get; set; }

    public string? Tg3 { get; set; }

    public string? Tg4 { get; set; }

    public string? Tg5 { get; set; }

    public string? Tg6 { get; set; }

    public string? Tg7 { get; set; }

    public string? Tg8 { get; set; }

    public string? Tg9 { get; set; }

    public string? Tg10 { get; set; }

    public string? Tg11 { get; set; }

    public string? Tg12 { get; set; }

    public string? Tg13 { get; set; }

    public string? Tg14 { get; set; }

    public string? Tg15 { get; set; }

    public string? Tg16 { get; set; }

    public string? MagSede { get; set; }

    public int? Assegnati { get; set; }

    public int? TotDaLanc { get; set; }

    public int? TotTag { get; set; }

    public int? TotSped { get; set; }

    public int? TotAnn { get; set; }

    public int? MagDisp { get; set; }

    public int? MagAss { get; set; }

    public int? MagDispDaAss { get; set; }

    public double? List1 { get; set; }

    public int? IdLabPrev { get; set; }

    public string? LabPrev { get; set; }

    public string? MadeIn { get; set; }

    public string? MadeInDesc { get; set; }

    public string? Umpeso { get; set; }

    public int? Peso { get; set; }

    public string? CdOp { get; set; }

    public int? IdGender { get; set; }

    public int? TotVend { get; set; }

    public int? IdAvanzMod { get; set; }

    public int? TotRecup { get; set; }

    public string? Lav1 { get; set; }

    public string? Lav2 { get; set; }

    public string? Lav3 { get; set; }

    public string? Lav4 { get; set; }

    public string? Lav5 { get; set; }

    public string? Lav6 { get; set; }

    public string? Mid { get; set; }

    public string? DescCommerc { get; set; }

    public string? CatMercMacroCod { get; set; }

    public string? CatMercMacroDesc { get; set; }

    public string? HsCode { get; set; }

    public string? HsCodeDesc { get; set; }

    public string? Kw { get; set; }

    public string? Imballo { get; set; }

    public bool? Cont { get; set; }

    public int? Idlav1 { get; set; }

    public int? Idlav2 { get; set; }

    public int? Idlav3 { get; set; }

    public int? Idlav4 { get; set; }

    public int? Idlav5 { get; set; }

    public int? Idlav6 { get; set; }

    public string? CatMerc2 { get; set; }

    public string? CatMercMacroDesc2 { get; set; }

    public bool? CkDiBa { get; set; }

    public int? IdFornPref { get; set; }

    public string? Fornitore { get; set; }

    public string? GenderCod { get; set; }

    public string? GenderDesc { get; set; }

    public byte[]? DocumentaleImg { get; set; }

    public byte[]? Immagine { get; set; }

    public byte[]? AvanzModImg { get; set; }

    public string? StatoApp { get; set; }

    public string? StatoExp { get; set; }

    public int? IdModNoStag { get; set; }

    public decimal? TotFasi { get; set; }

    public decimal? TotMatT { get; set; }

    public decimal? TotMatC { get; set; }

    public decimal? TotMatS { get; set; }

    public decimal? TotMatL { get; set; }

    public int? IdModCol { get; set; }

    public decimal? TotImp { get; set; }

    public decimal? TotCostoFisso { get; set; }

    public int? CostiPerc { get; set; }

    public decimal? TotCostoPerc { get; set; }

    public decimal? TotCosti { get; set; }

    public int? PercAddCosti { get; set; }

    public double? MarkUpIni { get; set; }

    public string? Ragg1Cod { get; set; }

    public string? Ragg1Desc { get; set; }

    public string? Guid { get; set; }

    public string? Tema { get; set; }

    public bool? CkLock { get; set; }

    public bool? CkLockDiBa { get; set; }

    public string? StatoAppDiBa { get; set; }

    public string? StatoAppDesc { get; set; }

    public string? DocCaptiv { get; set; }

    public string? DocNomeCom { get; set; }

    public string? DocNomeSci { get; set; }

    public string? DocProveni { get; set; }

    public string? DocTrattamento { get; set; }

    public string? NotaCare1 { get; set; }

    public string? NotaCare2 { get; set; }

    public string? Linea2 { get; set; }

    public string? LineaDesc2 { get; set; }
}

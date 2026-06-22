using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VElencoProdotti2
{
    public string Stato { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public int IdStag { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string Tess { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string? Cad { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? IdTagliaBase { get; set; }

    public short? IdTagliaDa { get; set; }

    public short? IdTagliaA { get; set; }

    public string? Tg { get; set; }

    public string TipoModello { get; set; } = null!;

    public short? IdComp { get; set; }

    public int? IdComp2 { get; set; }

    public int? IdComp3 { get; set; }

    public int? IdComp4 { get; set; }

    public int? IdComp5 { get; set; }

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

    public int TotVend { get; set; }

    public int MagSede { get; set; }

    public int Assegnati { get; set; }

    public int TotTag { get; set; }

    public int TotSped { get; set; }

    public int TotAnn { get; set; }

    public int List1 { get; set; }

    public int? IdLabPrev { get; set; }

    public string? LabPrev { get; set; }

    public string? MadeIn { get; set; }

    public string? MadeInDesc { get; set; }

    public string? Umpeso { get; set; }

    public short? Peso { get; set; }

    public string? CdOp { get; set; }

    public short? IdGender { get; set; }

    public string? GenderCod { get; set; }

    public string? GenderDesc { get; set; }

    public int? IdStatoMod { get; set; }

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

    public string HsCodeDesc { get; set; } = null!;

    public string? Kw { get; set; }

    public string? Imballo { get; set; }

    public int? Cont { get; set; }

    public int? Idlav1 { get; set; }

    public int? Idlav2 { get; set; }

    public int? Idlav3 { get; set; }

    public int? Idlav4 { get; set; }

    public int? Idlav5 { get; set; }

    public int? Idlav6 { get; set; }

    public bool CkSemilav { get; set; }

    public int? IdMat { get; set; }

    public int? IdCatMercMacro2 { get; set; }

    public string? CatMercMacroDesc2 { get; set; }

    public int? IdCatMerc2 { get; set; }

    public string? CatMerc2 { get; set; }

    public string? Stagionalita { get; set; }

    public string? Vestibilita { get; set; }

    public int? IdFornPref { get; set; }

    public string? Fornitore { get; set; }

    public int? IdCad { get; set; }

    public int? IdAvanzMod { get; set; }

    public string? AvanzMod { get; set; }

    public byte[]? AvanzModImg { get; set; }

    public int? IdPos1 { get; set; }

    public int? IdPos2 { get; set; }

    public int? IdPos3 { get; set; }

    public int? IdPos4 { get; set; }

    public int? IdPos5 { get; set; }

    public string? StatoExp { get; set; }

    public string? StatoApp { get; set; }

    public int? IdModNoStag { get; set; }

    public string? Ragg1Cod { get; set; }

    public string? Ragg1Desc { get; set; }

    public string? StatoAppDesc { get; set; }

    public string? Guid { get; set; }

    public short? IdTema { get; set; }

    public string? Tema { get; set; }

    public string? StatoAppDiBa { get; set; }

    public bool? CkLock { get; set; }

    public bool? CkLockDiBa { get; set; }

    public string? CdAll { get; set; }

    public string? DocCaptiv { get; set; }

    public string? DocNomeCom { get; set; }

    public string? DocNomeSci { get; set; }

    public string? DocProveni { get; set; }

    public string? DocTrattamento { get; set; }

    public string? NotaCare1 { get; set; }

    public string? NotaCare2 { get; set; }

    public short? IdLinea2 { get; set; }

    public string? Linea2 { get; set; }

    public string? LineaDesc2 { get; set; }
}

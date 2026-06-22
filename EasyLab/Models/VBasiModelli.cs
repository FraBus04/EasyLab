using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiModelli
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public string Stato { get; set; } = null!;

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public int IdStag { get; set; }

    public string? Stag { get; set; }

    public string? StagDesc { get; set; }

    public string TipoModello { get; set; } = null!;

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string? GenderCod { get; set; }

    public string? GenderDesc { get; set; }

    public int? IdLinea { get; set; }

    public string? Linea { get; set; }

    public string? LineaDesc { get; set; }

    public int? IdCatMerc { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public int? IdModellista { get; set; }

    public string? Modellista { get; set; }

    public double? Listino { get; set; }

    public string? MadeIn { get; set; }

    public string? MadeInDesc { get; set; }

    public string? Composizione { get; set; }

    public string? PathImg { get; set; }

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

    public string? Composizione2 { get; set; }

    public string? Composizione3 { get; set; }

    public string? Composizione4 { get; set; }

    public string? Composizione5 { get; set; }

    public string? Pos1 { get; set; }

    public string? Pos2 { get; set; }

    public string? Pos3 { get; set; }

    public string? Pos4 { get; set; }

    public string? Pos5 { get; set; }

    public string? Kw { get; set; }

    public int? IdSet { get; set; }

    public int? IdTagliaBase { get; set; }

    public short? IdTagliaDa { get; set; }

    public short? IdTagliaA { get; set; }

    public string? Mid { get; set; }

    public string? DescCommerc { get; set; }

    public int? IdCatMercMacro { get; set; }

    public string? CatMercMacroCod { get; set; }

    public string? CatMercMacroDesc { get; set; }

    public int? IdStatoMod { get; set; }

    public string StatoModCod { get; set; } = null!;

    public string StatoMod { get; set; } = null!;

    public string StatoModBreve { get; set; } = null!;

    public string StatoModOrdPm { get; set; } = null!;

    public string? Cad { get; set; }

    public string? Nota { get; set; }

    public string? BaseProv { get; set; }

    public string? FilatoCucit { get; set; }

    public string? FilatoImp { get; set; }

    public string? TipoPunto { get; set; }

    public string? HsCode { get; set; }

    public string HsCodeDesc { get; set; } = null!;

    public string? Op { get; set; }

    public string? Stiro { get; set; }

    public string? Imballo { get; set; }

    public string? PathLogo { get; set; }

    public string? TagliaDa { get; set; }

    public string? TagliaA { get; set; }

    public string? TagliaBase { get; set; }

    public int? LeadTimeGg { get; set; }

    public DateOnly? DataPianifProd { get; set; }

    public int? Idlav1 { get; set; }

    public int? Idlav2 { get; set; }

    public int? Idlav3 { get; set; }

    public int? Idlav4 { get; set; }

    public int? Idlav5 { get; set; }

    public int? Idlav6 { get; set; }

    public int? IdLav11 { get; set; }

    public int? IdLav12 { get; set; }

    public int? IdLav13 { get; set; }

    public int? IdLav14 { get; set; }

    public int? IdLav15 { get; set; }

    public int? IdLav16 { get; set; }

    public string? Lav1 { get; set; }

    public string? Lav2 { get; set; }

    public string? Lav3 { get; set; }

    public string? Lav4 { get; set; }

    public string? Lav5 { get; set; }

    public string? Lav6 { get; set; }

    public string? Lav11 { get; set; }

    public string? Lav12 { get; set; }

    public string? Lav13 { get; set; }

    public string? Lav14 { get; set; }

    public string? Lav15 { get; set; }

    public string? Lav16 { get; set; }

    public bool CkSemilav { get; set; }

    public int? IdMat { get; set; }

    public int? IdTrattamento { get; set; }

    public string? Trattamento { get; set; }

    public short? IdFilCucit { get; set; }

    public short? IdFilImp { get; set; }

    public short? IdTipoPunto { get; set; }

    public short? IdComp { get; set; }

    public short? IdTaric { get; set; }

    public short? IdNazione { get; set; }

    public short? IdGender { get; set; }

    public int? IdStiro { get; set; }

    public int? IdImballo { get; set; }

    public int? IdKw { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdCatMercMacro2 { get; set; }

    public string? CatMercMacroCod2 { get; set; }

    public string? CatMercMacroDesc2 { get; set; }

    public int? IdCatMerc2 { get; set; }

    public string? CatMercCod2 { get; set; }

    public string? CatMercDesc2 { get; set; }

    public int? IdVest { get; set; }

    public int? IdStagionalita { get; set; }

    public int? IdFornPref { get; set; }

    public string? StatoImp { get; set; }

    public int? IdComp2 { get; set; }

    public int? IdComp3 { get; set; }

    public int? IdComp4 { get; set; }

    public int? IdComp5 { get; set; }

    public int? IdPos1 { get; set; }

    public int? IdPos2 { get; set; }

    public int? IdPos3 { get; set; }

    public int? IdPos4 { get; set; }

    public int? IdPos5 { get; set; }

    public int? IdLabPrev { get; set; }

    public bool? CkComp { get; set; }

    public int? CkCompEtic { get; set; }

    public string? FornPref { get; set; }

    public string? Vest { get; set; }

    public string? CodArtFornitore { get; set; }

    public string? DescBreve { get; set; }

    public string? Um { get; set; }

    public string? StatoApp { get; set; }

    public string? StatoAppDiBa { get; set; }

    public string? StagionalitaCod { get; set; }

    public string? StagionalitaDesc { get; set; }

    public int? IdAvanzMod { get; set; }

    public string? AvanzModCod { get; set; }

    public string? AvanzMod { get; set; }

    public int? AvanzModOrdPm { get; set; }

    public string? AvanzModBreve { get; set; }

    public int? IdCart { get; set; }

    public string? LabPrev { get; set; }

    public string? StatoAppDesc { get; set; }

    public int? IdModNoStag { get; set; }

    public string? Produz { get; set; }

    public short? Peso { get; set; }

    public string? CdOp { get; set; }

    public int? IdProduz { get; set; }

    public string? StatoExp { get; set; }

    public string? Ragg1Desc { get; set; }

    public string? Ragg2Desc { get; set; }

    public string? Ragg3Desc { get; set; }

    public string? Ragg4Desc { get; set; }

    public string? Ragg5Desc { get; set; }

    public int? StagOrd { get; set; }

    public string? Lav0NotaAgg { get; set; }

    public int? Idlav0 { get; set; }

    public int? IdLav00 { get; set; }

    public int? IdDocCaptiv { get; set; }

    public int? IdDocNomeCom { get; set; }

    public int? IdDocNomeSci { get; set; }

    public int? IdDocProveni { get; set; }

    public int? IdDocTrattamento { get; set; }

    public string? TipoModelloDesc { get; set; }

    public bool? CkLock { get; set; }

    public bool? CkLockDiBa { get; set; }

    public string? StatoAppBol { get; set; }

    public bool? CkLockBol { get; set; }

    public bool? CkBulletPoint { get; set; }

    public string? CdAll { get; set; }
}

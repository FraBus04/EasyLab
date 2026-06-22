using System;
using System.Collections.Generic;

namespace EasyLab.Models;

/// <summary>
/// P - ProdottiC - CadM - MaterialiS - Semilavorati
/// </summary>
public partial class BasiModelli
{
    public int Id { get; set; }

    public string? Cd { get; set; }

    public string? Guid { get; set; }

    /// <summary>
    /// PR Prodotto
    /// SL Semilavorato
    /// CD Cad MD Modello
    /// </summary>
    public string Tipo { get; set; } = null!;

    public bool CkSemilav { get; set; }

    public string Stato { get; set; } = null!;

    public int IdContatto { get; set; }

    public int? IdModNoStag { get; set; }

    public int IdStag { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? IdTagliaBase { get; set; }

    public short? IdTagliaDa { get; set; }

    public short? IdTagliaA { get; set; }

    public string Mdl { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string? Cad { get; set; }

    public string? Nota { get; set; }

    public string? PathImg { get; set; }

    public string? BaseProv { get; set; }

    public bool? CkModello { get; set; }

    public string? NotaCostruz { get; set; }

    public string? CodArtFornitore { get; set; }

    public int? IdCatMerc { get; set; }

    public int? IdCatMerc2 { get; set; }

    public int? IdCatMercMacro { get; set; }

    public int? IdCatMercMacro2 { get; set; }

    public int? IdModellista { get; set; }

    public double? Listino { get; set; }

    public short? IdLinea { get; set; }

    public int? IdStatoMod { get; set; }

    public int? IdTrattamento { get; set; }

    public string TipoModello { get; set; } = null!;

    public int? IdTabAnagCliFor { get; set; }

    public short? IdFilCucit { get; set; }

    public short? IdFilImp { get; set; }

    public short? IdTipoPunto { get; set; }

    public short? CkStampa { get; set; }

    public short? IdTema { get; set; }

    public short? IdTaric { get; set; }

    public short? IdNazione { get; set; }

    public int? IdFornPref { get; set; }

    public int? IdLabPrev { get; set; }

    public string? Mid { get; set; }

    public short? Peso { get; set; }

    public string? Umpeso { get; set; }

    public string? Um { get; set; }

    public string? CdOp { get; set; }

    public short? IdGender { get; set; }

    public int? IdScheda { get; set; }

    public int? IdStiro { get; set; }

    public int? IdImballo { get; set; }

    public int? IdKw { get; set; }

    public bool? CkComp { get; set; }

    public short? IdComp { get; set; }

    public int? IdComp2 { get; set; }

    public int? IdComp3 { get; set; }

    public int? IdComp4 { get; set; }

    public int? IdComp5 { get; set; }

    public int? IdPos1 { get; set; }

    public int? IdPos2 { get; set; }

    public int? IdPos3 { get; set; }

    public int? IdPos4 { get; set; }

    public int? IdPos5 { get; set; }

    public int? Idlav0 { get; set; }

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

    public string? DescCommerc { get; set; }

    public int? LeadTimeGg { get; set; }

    public DateOnly? DataPianifProd { get; set; }

    public int? IdMat { get; set; }

    public int? IdVest { get; set; }

    public int? IdStagionalita { get; set; }

    public int? IdCad { get; set; }

    public int? IdAvanzMod { get; set; }

    public int? IdRagg1 { get; set; }

    public int? IdRagg2 { get; set; }

    public int? IdRagg3 { get; set; }

    public int? IdRagg4 { get; set; }

    public int? IdRagg5 { get; set; }

    public int? IdProduz { get; set; }

    public int? IdCart { get; set; }

    public string? VociDoganali { get; set; }

    public DateTime? DataImp { get; set; }

    public DateTime? DataExp { get; set; }

    /// <summary>
    /// &apos;&apos;
    /// </summary>
    public string? StatoExp { get; set; }

    public string? StatoImp { get; set; }

    public string? StatoApp { get; set; }

    public int? IdUteApp { get; set; }

    public DateTime? DateApp { get; set; }

    public string? DescBreve { get; set; }

    public DateTime? DataUpd { get; set; }

    public DateTime? DataIns { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? IdModFrom { get; set; }

    public int? IdLav00 { get; set; }

    public int? IdDocCaptiv { get; set; }

    public int? IdDocNomeCom { get; set; }

    public int? IdDocNomeSci { get; set; }

    public int? IdDocProveni { get; set; }

    public int? IdDocTrattamento { get; set; }

    public string? StatoAppDiBa { get; set; }

    public string? StatoAppBol { get; set; }

    public bool? CkLock { get; set; }

    public bool? CkLockDiBa { get; set; }

    public bool? CkLockBol { get; set; }

    public bool? CkBulletPoint { get; set; }

    public short? IdLinea2 { get; set; }
}

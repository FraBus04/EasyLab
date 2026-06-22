using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiMateriali
{
    public int Id { get; set; }

    public string? Cd { get; set; }

    public string? Guid { get; set; }

    public string? Stato { get; set; }

    public int IdContatto { get; set; }

    public string Mat { get; set; } = null!;

    public string DescMat { get; set; } = null!;

    public string? CdFamMat { get; set; }

    public int IdTipoMat { get; set; }

    public int IdTipoMat2 { get; set; }

    public string Tp { get; set; } = null!;

    public int? IdTp { get; set; }

    public int IdFornitore { get; set; }

    public string CodArtFornitore { get; set; } = null!;

    public bool CkAbbModello { get; set; }

    public bool CkMatColore { get; set; }

    public bool CkMatMis { get; set; }

    public bool CkMatTaglio { get; set; }

    public bool CkSemilav { get; set; }

    public string? Umacq { get; set; }

    public string? Um { get; set; }

    public string? Umpeso { get; set; }

    public short? Peso { get; set; }

    public short? PesoMtq { get; set; }

    public short? Hforn { get; set; }

    public short? Hutile { get; set; }

    public string? MinProd { get; set; }

    public string? LungPezze { get; set; }

    public int? MultOrd { get; set; }

    public int? LeadTimeGg { get; set; }

    public string? LeadTime { get; set; }

    public string? Nota { get; set; }

    public string? DescCommerc { get; set; }

    public string? PathImg { get; set; }

    public string? CdOp { get; set; }

    public short? IdNazione { get; set; }

    public short? IdTaric { get; set; }

    public int? IdStagUltima { get; set; }

    public int? IdCatTag { get; set; }

    public int? IdMod { get; set; }

    public int? IdTrattamento { get; set; }

    public bool? IdStagFabb { get; set; }

    public int? IdMpscar { get; set; }

    public string? CdValuta { get; set; }

    public double? Pz { get; set; }

    public double? PzCamp { get; set; }

    public double? MisCostoFisso { get; set; }

    public double? MisCostoVar { get; set; }

    public double? MisCostoSco { get; set; }

    public double? Tempo { get; set; }

    public int? IdComp { get; set; }

    public int? IdComp2 { get; set; }

    public int? IdComp3 { get; set; }

    public int? IdPos1 { get; set; }

    public int? IdPos2 { get; set; }

    public int? IdPos3 { get; set; }

    public int? Idlav1 { get; set; }

    public int? Idlav2 { get; set; }

    public int? Idlav3 { get; set; }

    public int? Idlav4 { get; set; }

    public int? Idlav5 { get; set; }

    public int? Idlav6 { get; set; }

    public int? IdRagg1 { get; set; }

    public int? IdRagg2 { get; set; }

    public int? IdRagg3 { get; set; }

    public int? IdRagg4 { get; set; }

    public int? IdRagg5 { get; set; }

    public string? VociDoganali { get; set; }

    public bool? CkGestioneLotti { get; set; }

    public int? IdCart { get; set; }

    public bool? CkMp { get; set; }

    public bool? CkMrp { get; set; }

    public bool? CkFabb { get; set; }

    public bool? CkSfrido { get; set; }

    public double? Sfrido { get; set; }

    public bool? CkOrigAnimale { get; set; }

    public string? CdMag { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public DateTime? DataImp { get; set; }

    public DateTime? DataExp { get; set; }

    public string? StatoImp { get; set; }

    public string? StatoExp { get; set; }

    public int? IdLav0 { get; set; }

    public int? IdDocCaptiv { get; set; }

    public int? IdDocNomeCom { get; set; }

    public int? IdDocNomeSci { get; set; }

    public int? IdDocProveni { get; set; }

    public int? IdDocTrattamento { get; set; }

    public string? Umutil { get; set; }

    public int? UmutilConv { get; set; }

    public string? StatoApp { get; set; }

    public string? StatoAppDiBa { get; set; }

    public bool? CkLock { get; set; }

    public bool? CkLockDiBa { get; set; }

    public bool? CkBulletPoint { get; set; }

    public string? Tipo { get; set; }

    public string? StatoAppBol { get; set; }
}

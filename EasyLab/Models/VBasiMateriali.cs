using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiMateriali
{
    public int IdMat { get; set; }

    public string? Cd { get; set; }

    public string? Stato { get; set; }

    public int IdContatto { get; set; }

    public string Mat { get; set; } = null!;

    public string DescMat { get; set; } = null!;

    public int IdFornitore { get; set; }

    public string Fornitore { get; set; } = null!;

    public string CodArtFornitore { get; set; } = null!;

    public string? Um { get; set; }

    public string? Umpeso { get; set; }

    public short? Peso { get; set; }

    public short? PesoMtq { get; set; }

    public short? Hforn { get; set; }

    public short? Hutile { get; set; }

    public string? CdOp { get; set; }

    public string? Op { get; set; }

    public string? CdNazioni { get; set; }

    public string? Nazioni { get; set; }

    public string? HsCode { get; set; }

    public int? LeadTimeGg { get; set; }

    public string? CdTipoMat { get; set; }

    public string? CdCatTag { get; set; }

    public int? IdComp { get; set; }

    public string? Composizione { get; set; }

    public string? Lav1 { get; set; }

    public string? Lav2 { get; set; }

    public string? Lav3 { get; set; }

    public string? Lav4 { get; set; }

    public string? Lav5 { get; set; }

    public string? Lav6 { get; set; }

    public int? IdStagUltima { get; set; }

    public string? StagUltima { get; set; }

    public string? PathImg { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? CdFamMat { get; set; }

    public string? MacroGruppo { get; set; }

    public int? MultOrd { get; set; }

    public string? MinProd { get; set; }

    public string? LungPezze { get; set; }

    public string MatDesc { get; set; } = null!;

    public int? IdComp2 { get; set; }

    public int? IdComp3 { get; set; }

    public int? IdPos1 { get; set; }

    public int? IdPos2 { get; set; }

    public int? IdPos3 { get; set; }

    public string Tp { get; set; } = null!;

    public string? Composizione2 { get; set; }

    public string? Composizione3 { get; set; }

    public string? Posizione { get; set; }

    public string? Posizione2 { get; set; }

    public string? Posizione3 { get; set; }

    public string? TpDesc { get; set; }

    public double? Pz { get; set; }

    public string? TipoMatDesc { get; set; }

    public int? TipoMatOrdPm { get; set; }

    public string? CatTagDesc { get; set; }

    public string? DescCommerc { get; set; }

    public bool CkMatMis { get; set; }

    public string? Contatto { get; set; }

    public double? MisCostoFisso { get; set; }

    public double? MisCostoVar { get; set; }

    public double? MisCostoSco { get; set; }

    public string? Nota { get; set; }

    public string? CdValuta { get; set; }

    public double? Tempo { get; set; }

    public bool CkMatTaglio { get; set; }

    public bool CkMatColore { get; set; }

    public bool CkAbbModello { get; set; }

    public string? Umacq { get; set; }

    public string? LeadTime { get; set; }

    public int? IdMpscar { get; set; }

    public int IdTipoMat { get; set; }

    public string? PathLogo { get; set; }

    public int? Idlav1 { get; set; }

    public int? Idlav2 { get; set; }

    public int? Idlav3 { get; set; }

    public int? Idlav4 { get; set; }

    public int? Idlav5 { get; set; }

    public int? Idlav6 { get; set; }

    public bool CkSemilav { get; set; }

    public int? IdMod { get; set; }

    public bool? IdStagFabb { get; set; }

    public string? AnagCliForCod { get; set; }

    public int? NrAllegati { get; set; }

    public byte[]? DocumentaleImg { get; set; }

    public bool? CkMp { get; set; }

    public bool? CkMrp { get; set; }

    public bool? CkFabb { get; set; }

    public bool? CkSfrido { get; set; }

    public double? Sfrido { get; set; }

    public bool? CkOrigAnimale { get; set; }

    public string? CdMag { get; set; }

    public DateTime? DataImp { get; set; }

    public DateTime? DataExp { get; set; }

    public string? StatoImp { get; set; }

    public string? StatoExp { get; set; }

    public int? IdLav0 { get; set; }

    public string? Lav0NotaAgg { get; set; }

    public string? StatoApp { get; set; }

    public string? StatoAppDiBa { get; set; }

    public bool? CkLock { get; set; }

    public bool? CkLockDiBa { get; set; }

    public string? Mpscar { get; set; }

    public string? Tipo { get; set; }
}

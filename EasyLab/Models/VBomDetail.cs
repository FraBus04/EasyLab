using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBomDetail
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int? IdContattoMat { get; set; }

    public int IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public string? Stag { get; set; }

    public string? StagDesc { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string? Nome { get; set; }

    public string CodColProd { get; set; } = null!;

    public int Seq { get; set; }

    public int? IdMat { get; set; }

    public int? IdCodColMat { get; set; }

    public int? IdMisura { get; set; }

    public string CdMat { get; set; } = null!;

    public string? CodColMat { get; set; }

    public string? Misura { get; set; }

    public bool? CkMatMis { get; set; }

    public string? CdUm { get; set; }

    public double? Cons { get; set; }

    public bool CkMp { get; set; }

    public bool CkMrp { get; set; }

    public bool CkFabb { get; set; }

    public string? CdClasseImpegno { get; set; }

    public string? Posizione { get; set; }

    public string? Note { get; set; }

    public string? DescMat { get; set; }

    public string? Tp { get; set; }

    public string? Tp2 { get; set; }

    public string? Tp3 { get; set; }

    public string? Misura1 { get; set; }

    public string? Misura2 { get; set; }

    public string? Misura3 { get; set; }

    public string? Misura4 { get; set; }

    public string? Misura5 { get; set; }

    public string? Misura6 { get; set; }

    public string? Misura7 { get; set; }

    public string? Misura8 { get; set; }

    public string? Misura9 { get; set; }

    public string? Misura10 { get; set; }

    public string? Misura11 { get; set; }

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

    public string? Tpdesc { get; set; }

    public string? Tp2desc { get; set; }

    public string? Tp3desc { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public bool? CkContr { get; set; }

    public double? PzMatUm { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public DateTime? Ts { get; set; }

    public string? Stato { get; set; }
}

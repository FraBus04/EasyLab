using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BomReticolo
{
    public int Id { get; set; }

    public int IdRigaBom { get; set; }

    public string TipoRiga { get; set; } = null!;

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public int Seq { get; set; }

    public string CdMat { get; set; } = null!;

    public string? CdUm { get; set; }

    public string? Misura { get; set; }

    public double? Cons { get; set; }

    public bool CkMp { get; set; }

    public bool CkMrp { get; set; }

    public bool CkFabb { get; set; }

    public string? CdClasseImpegno { get; set; }

    public string? Posizione { get; set; }

    public string? Note { get; set; }

    public int? IdMod { get; set; }

    public string? Tp { get; set; }

    public string? Tp2 { get; set; }

    public string? CodColVend01 { get; set; }

    public string? CodColVend02 { get; set; }

    public string? CodColVend03 { get; set; }

    public string? CodColVend04 { get; set; }

    public string? CodColVend05 { get; set; }

    public string? CodColVend06 { get; set; }

    public string? CodColVend07 { get; set; }

    public string? CodColVend08 { get; set; }

    public string? CodColVend09 { get; set; }

    public string? CodColVend10 { get; set; }

    public string? CodColVend11 { get; set; }

    public string? CodColVend12 { get; set; }

    public string? CodColVend13 { get; set; }

    public string? CodColVend14 { get; set; }

    public string? CodColVend15 { get; set; }

    public string? CodColMat01 { get; set; }

    public string? CodColMat02 { get; set; }

    public string? CodColMat03 { get; set; }

    public string? CodColMat04 { get; set; }

    public string? CodColMat05 { get; set; }

    public string? CodColMat06 { get; set; }

    public string? CodColMat07 { get; set; }

    public string? CodColMat08 { get; set; }

    public string? CodColMat09 { get; set; }

    public string? CodColMat10 { get; set; }

    public string? CodColMat11 { get; set; }

    public string? CodColMat12 { get; set; }

    public string? CodColMat13 { get; set; }

    public string? CodColMat14 { get; set; }

    public string? CodColMat15 { get; set; }

    public DateTime? Ts { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

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

    public string? Cons1 { get; set; }

    public string? Cons2 { get; set; }

    public string? Cons3 { get; set; }

    public string? Cons4 { get; set; }

    public string? Cons5 { get; set; }

    public string? Cons6 { get; set; }

    public string? Cons7 { get; set; }

    public string? Cons8 { get; set; }

    public string? Cons9 { get; set; }

    public string? Cons10 { get; set; }

    public string? Cons11 { get; set; }

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

    public bool? CkMatMis { get; set; }

    public bool? CkColUnico { get; set; }

    public string? Tp3 { get; set; }

    public int? IdMat { get; set; }

    public int? IdCodColVend01 { get; set; }

    public int? IdCodColVend02 { get; set; }

    public int? IdCodColVend03 { get; set; }

    public int? IdCodColVend04 { get; set; }

    public int? IdCodColVend05 { get; set; }

    public int? IdCodColVend06 { get; set; }

    public int? IdCodColVend07 { get; set; }

    public int? IdCodColVend08 { get; set; }

    public int? IdCodColVend09 { get; set; }

    public int? IdCodColVend10 { get; set; }

    public int? IdCodColVend11 { get; set; }

    public int? IdCodColVend12 { get; set; }

    public int? IdCodColVend13 { get; set; }

    public int? IdCodColVend14 { get; set; }

    public int? IdCodColVend15 { get; set; }

    public int? IdCodColMat01 { get; set; }

    public int? IdCodColMat02 { get; set; }

    public int? IdCodColMat03 { get; set; }

    public int? IdCodColMat04 { get; set; }

    public int? IdCodColMat05 { get; set; }

    public int? IdCodColMat06 { get; set; }

    public int? IdCodColMat07 { get; set; }

    public int? IdCodColMat08 { get; set; }

    public int? IdCodColMat09 { get; set; }

    public int? IdCodColMat10 { get; set; }

    public int? IdCodColMat11 { get; set; }

    public int? IdCodColMat12 { get; set; }

    public int? IdCodColMat13 { get; set; }

    public int? IdCodColMat14 { get; set; }

    public int? IdCodColMat15 { get; set; }

    public int? IdMisura1 { get; set; }

    public int? IdMisura2 { get; set; }

    public int? IdMisura3 { get; set; }

    public int? IdMisura4 { get; set; }

    public int? IdMisura5 { get; set; }

    public int? IdMisura6 { get; set; }

    public int? IdMisura7 { get; set; }

    public int? IdMisura8 { get; set; }

    public int? IdMisura9 { get; set; }

    public int? IdMisura10 { get; set; }

    public int? IdMisura11 { get; set; }

    public int? IdMisura { get; set; }

    public int? CkModif { get; set; }

    public string? Stato { get; set; }

    public int? IdModCol { get; set; }

    public int? TotCapi { get; set; }

    public int? Nr1 { get; set; }

    public int? Nr2 { get; set; }

    public int? Nr3 { get; set; }

    public int? Nr4 { get; set; }

    public int? Nr5 { get; set; }

    public int? Nr6 { get; set; }

    public int? Nr7 { get; set; }

    public int? Nr8 { get; set; }

    public int? Nr9 { get; set; }

    public int? Nr10 { get; set; }

    public int? Nr11 { get; set; }

    public int? Nr12 { get; set; }

    public int? Nr13 { get; set; }

    public int? Nr14 { get; set; }

    public int? Nr15 { get; set; }

    public int? TotVendMod { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBomReticolo
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int? IdMod { get; set; }

    public string? Stag { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public int Seq { get; set; }

    public string CdMat { get; set; } = null!;

    public string? DescMat { get; set; }

    public string? CdUm { get; set; }

    public string? Misura { get; set; }

    public double? Cons { get; set; }

    public bool CkMp { get; set; }

    public bool CkMrp { get; set; }

    public bool CkFabb { get; set; }

    public string? CdClasseImpegno { get; set; }

    public string? Posizione { get; set; }

    public string? Note { get; set; }

    public string? Nome { get; set; }

    public string? Tp2 { get; set; }

    public string? PathImg { get; set; }

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

    public string? DescColVend01 { get; set; }

    public string? DescColVend02 { get; set; }

    public string? DescColVend03 { get; set; }

    public string? DescColVend04 { get; set; }

    public string? DescColVend05 { get; set; }

    public string? DescColVend06 { get; set; }

    public string? DescColVend07 { get; set; }

    public string? DescColVend08 { get; set; }

    public string? DescColVend09 { get; set; }

    public string? DescColVend10 { get; set; }

    public string? DescColVend11 { get; set; }

    public string? DescColVend12 { get; set; }

    public string? DescColVend13 { get; set; }

    public string? DescColVend14 { get; set; }

    public string? DescColVend15 { get; set; }

    public string? PathImgVend01 { get; set; }

    public string? PathImgVend02 { get; set; }

    public string? PathImgVend03 { get; set; }

    public string? PathImgVend04 { get; set; }

    public string? PathImgVend05 { get; set; }

    public string? PathImgVend06 { get; set; }

    public string? PathImgVend07 { get; set; }

    public string? PathImgVend08 { get; set; }

    public string? PathImgVend09 { get; set; }

    public string? PathImgVend10 { get; set; }

    public string? PathImgVend11 { get; set; }

    public string? PathImgVend12 { get; set; }

    public string? PathImgVend13 { get; set; }

    public string? PathImgVend14 { get; set; }

    public string? PathImgVend15 { get; set; }

    public string? DescColMat01 { get; set; }

    public string? DescColMat02 { get; set; }

    public string? DescColMat03 { get; set; }

    public string? DescColMat04 { get; set; }

    public string? DescColMat05 { get; set; }

    public string? DescColMat06 { get; set; }

    public string? DescColMat07 { get; set; }

    public string? DescColMat08 { get; set; }

    public string? DescColMat09 { get; set; }

    public string? DescColMat10 { get; set; }

    public string? DescColMat11 { get; set; }

    public string? DescColMat12 { get; set; }

    public string? DescColMat13 { get; set; }

    public string? DescColMat14 { get; set; }

    public string? DescColMat15 { get; set; }

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

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

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

    public string? Composizione { get; set; }

    public string? Lav1 { get; set; }

    public string? Lav2 { get; set; }

    public string? Lav3 { get; set; }

    public string? Lav4 { get; set; }

    public string? Lav5 { get; set; }

    public string? Lav6 { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public string? Tp2desc { get; set; }

    public string? Tp3 { get; set; }

    public string? Tp3desc { get; set; }

    public int? IdMat { get; set; }

    public string? Modellista { get; set; }

    public string? CatMercMacroCod { get; set; }

    public string? CatMercMacroDesc { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public string? Linea { get; set; }

    public string? TipoModello { get; set; }

    public string? TipoModelloDesc { get; set; }

    public string? MatCompany { get; set; }

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

    public bool? CkColUnico { get; set; }

    public double? Cons1 { get; set; }

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

    public string? Stato { get; set; }

    public string? CodArtFornitore { get; set; }

    public bool? CkContr { get; set; }

    public int? CkScheda { get; set; }

    public string? Tp { get; set; }
}

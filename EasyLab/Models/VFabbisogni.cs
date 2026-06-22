using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VFabbisogni
{
    public int Id { get; set; }

    public int? IdContatto { get; set; }

    public string Tipo { get; set; } = null!;

    public int? IdStag { get; set; }

    public string Stato { get; set; } = null!;

    public string? Mat { get; set; }

    public string? DescMat { get; set; }

    public string? ColMat { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? ColProd { get; set; }

    public string? Misura { get; set; }

    public double? FabbNetto { get; set; }

    public int? FornCod { get; set; }

    public string? FornDesc { get; set; }

    public int? IdMod { get; set; }

    public int? IdTesta { get; set; }

    public int? Seq { get; set; }

    public double? Cons { get; set; }

    public string? CodArtFornitore { get; set; }

    public string? Um { get; set; }

    public string? DescColMat { get; set; }

    public string? DescColProd { get; set; }

    public short? CapiFabbNetto { get; set; }

    public string? CdTipoMat { get; set; }

    public double? MagQta { get; set; }

    public double? MagQtaDiff { get; set; }

    public string? StagCod { get; set; }

    public string? StagDesc { get; set; }

    public string? LabPrevMod { get; set; }

    public short? CapiFabbNettoMod { get; set; }

    public bool? CkMp { get; set; }

    public bool? CkMrp { get; set; }

    public bool? CkFabb { get; set; }

    public string? Posizione { get; set; }

    public string? Note { get; set; }

    public string? Tp { get; set; }

    public string? Tp2 { get; set; }

    public DateTime Ts { get; set; }

    public string? TipoModello { get; set; }

    public short? Peso { get; set; }

    public string? Modellista { get; set; }

    public string? Composizione { get; set; }

    public string? HsCode { get; set; }

    public string? MadeIn { get; set; }

    public string? Lav1 { get; set; }

    public string? Lav2 { get; set; }

    public string? Lav3 { get; set; }

    public string? Lav4 { get; set; }

    public string? Lav5 { get; set; }

    public string? Lav6 { get; set; }

    public string? Tg { get; set; }

    public string? TgCli { get; set; }

    public string? PathImgMod { get; set; }

    public string? PathmgCol { get; set; }

    public double? FabbLordi { get; set; }

    public short? CapiFabbLordi { get; set; }

    public string? TipoMatDesc { get; set; }

    public int? TipoMatOrd { get; set; }

    public double? Pz { get; set; }

    public int? IdLabPrev { get; set; }

    public int IdMat { get; set; }

    public int IdModCol { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public int? IdContattoMat { get; set; }

    public string? ContattoMat { get; set; }

    public string? Contatto { get; set; }

    public DateOnly? DataPianifProd { get; set; }

    public string? PathLogo { get; set; }

    public int? CapiFabbNetto1 { get; set; }

    public int? CapiFabbNetto2 { get; set; }

    public int? CapiFabbNetto3 { get; set; }

    public double? FabbNetto1 { get; set; }

    public double? FabbNetto2 { get; set; }

    public double? FabbNetto3 { get; set; }

    public int? IdRigaBomDetail { get; set; }

    public string? FamMatDesc { get; set; }

    public string? FamMatMacroGruppo { get; set; }

    public int? IdCanale { get; set; }

    public int? IdRagg1Ord { get; set; }
}

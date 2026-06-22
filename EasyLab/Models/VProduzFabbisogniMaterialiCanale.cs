using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzFabbisogniMaterialiCanale
{
    public int Id { get; set; }

    public int? IdCanale { get; set; }

    public string? CanaleCod { get; set; }

    public string? CanaleDesc { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public int? IdStag { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public string? Stato { get; set; }

    public string? Mat { get; set; }

    public string? MatCol { get; set; }

    public string? MatMis { get; set; }

    public short? Scad { get; set; }

    public int? IdMod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ColProd { get; set; }

    public string? DerDaMat { get; set; }

    public string? DerDaColMat { get; set; }

    public string? OrdTipo { get; set; }

    public double? FabbNetto1 { get; set; }

    public double? FabbNetto2 { get; set; }

    public double? FabbNetto3 { get; set; }

    public double? FabbLordi1 { get; set; }

    public double? FabbLordi2 { get; set; }

    public double? FabbLordi3 { get; set; }

    public int? CapiFabbNetto1 { get; set; }

    public int? CapiFabbNetto2 { get; set; }

    public int? CapiFabbNetto3 { get; set; }

    public int? CapiFabbLordi1 { get; set; }

    public int? CapiFabbLordi2 { get; set; }

    public int? CapiFabbLordi3 { get; set; }

    public int? Seq { get; set; }

    public double? Cons { get; set; }

    public bool? CkMatMis { get; set; }

    public int? IdSetTg { get; set; }

    public int? IdTg { get; set; }

    public int IdCodColProd { get; set; }

    public int? IdRigaBomDetail { get; set; }

    public int? CkPianif { get; set; }

    public int? OrdModPianif { get; set; }

    public string? DescMat { get; set; }

    public string? Forn { get; set; }

    public string? CodArtFornitore { get; set; }

    public string? DescCol { get; set; }

    public string? CodColForn { get; set; }

    public double? FabbNetto { get; set; }

    public double? FabbLordi { get; set; }

    public int? CapiFabbNetto { get; set; }

    public int? CapiFabbLordi { get; set; }
}

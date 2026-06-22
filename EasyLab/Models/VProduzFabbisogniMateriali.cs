using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzFabbisogniMateriali
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public int? IdContatto { get; set; }

    public int? IdTesta { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public string Stato { get; set; } = null!;

    public int IdMat { get; set; }

    public string? CdTipoMat { get; set; }

    public string? Mat { get; set; }

    public int IdMatCol { get; set; }

    public string? CodColMat { get; set; }

    public int IdMatMis { get; set; }

    public string? Misura { get; set; }

    public short? Scad { get; set; }

    public int? IdMod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ColProd { get; set; }

    public string? DerDaMat { get; set; }

    public string? DerDaColMat { get; set; }

    public string? OrdTipo { get; set; }

    public double? FabbNetto { get; set; }

    public double? FabbLordi { get; set; }

    public short? CapiFabbNetto { get; set; }

    public short? CapiFabbLordi { get; set; }

    public int? Seq { get; set; }

    public double? Cons { get; set; }

    public short? CapiFabbNettoMod { get; set; }

    public bool? CkMatMis { get; set; }

    public int? IdSetTg { get; set; }
}

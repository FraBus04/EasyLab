using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzFabbisogniMateriali
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public string? Tipo { get; set; }

    public int? IdContatto { get; set; }

    public int? IdStag { get; set; }

    public int? Livello { get; set; }

    public int? FabbLivello { get; set; }

    public bool? CkSemiLavPadre { get; set; }

    public bool? CkSemiLavFiglio { get; set; }

    public int? IdMod { get; set; }

    public int IdModCol { get; set; }

    public int? IdSetTg { get; set; }

    public int? IdTg { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public string? Mat { get; set; }

    public string? ColMat { get; set; }

    public short? Scad { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ColProd { get; set; }

    public string? DerDaMat { get; set; }

    public string? DerDaColMat { get; set; }

    public string? OrdTipo { get; set; }

    public double? FabbNetto { get; set; }

    public double? FabbLordi { get; set; }

    public double? CapiFabbNetto { get; set; }

    public double? CapiFabbLordi { get; set; }

    public string? Misura { get; set; }

    public int? IdTesta { get; set; }

    public int? Seq { get; set; }

    public double? Cons { get; set; }

    public short? CapiFabbNettoMod { get; set; }

    public bool? CkMatMis { get; set; }

    public int? IdRigaBomDetail { get; set; }

    public int? CkPianif { get; set; }

    public int? OrdModPianif { get; set; }

    public int? CapiFabbNetto1 { get; set; }

    public int? CapiFabbNetto2 { get; set; }

    public int? CapiFabbNetto3 { get; set; }

    public double? FabbNetto1 { get; set; }

    public double? FabbNetto2 { get; set; }

    public double? FabbNetto3 { get; set; }

    public int? IdCanale { get; set; }

    public int? IdRagg1Ord { get; set; }

    public int? IdRigaBomReticolo { get; set; }

    public string? SelCdMag { get; set; }

    public DateTime? DataIns { get; set; }

    public string? ATipo { get; set; }

    public string? ACdAll { get; set; }

    public string? ACdAllcol { get; set; }

    public string? ACdAllmis { get; set; }

    public bool? ACkSemilav { get; set; }

    public string? BTipo { get; set; }

    public string? BCdAll { get; set; }

    public string? BCdAllcol { get; set; }

    public string? BCdAllmis { get; set; }

    public bool? BCkSemilav { get; set; }

    public bool? BCkMatMis { get; set; }

    public int? IdSet { get; set; }

    public int? IdSetOrd { get; set; }

    public string? AParte { get; set; }

    public string? AParteCol { get; set; }

    public string? AParteMis { get; set; }

    public string? BParte { get; set; }

    public string? BParteCol { get; set; }

    public string? BParteMis { get; set; }

    public int? IdRigaBomDetailCol { get; set; }

    public int? IdRigaBomDetailMis { get; set; }

    public int? IdClasse { get; set; }
}

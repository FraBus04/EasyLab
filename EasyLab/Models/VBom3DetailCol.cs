using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBom3DetailCol
{
    public int Id { get; set; }

    public int IdRigaReticolo { get; set; }

    public string ACdAll { get; set; } = null!;

    public string ACdAllcol { get; set; } = null!;

    public int Ver { get; set; }

    public string BCdAll { get; set; } = null!;

    public string BCdAllcol { get; set; } = null!;

    public bool? CkMp { get; set; }

    public bool? CkMrp { get; set; }

    public bool? CkFabb { get; set; }

    public string? ATipo { get; set; }

    public int? AIdContatto { get; set; }

    public string? AParte { get; set; }

    public string? AParteDesc { get; set; }

    public string? AParteCol { get; set; }

    public string? AParteColDesc { get; set; }

    public bool? AParteColEnab { get; set; }

    public string? BTipo { get; set; }

    public int? BIdContatto { get; set; }

    public string? BParte { get; set; }

    public string? BParteDesc { get; set; }

    public string? BParteCol { get; set; }

    public string? BParteColDesc { get; set; }

    public bool? BParteColEnab { get; set; }

    public int? AIdSet { get; set; }

    public int? AIdTgBase { get; set; }

    public string? Tp { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public double? Cons { get; set; }

    public int? Seq { get; set; }

    public string? AStag { get; set; }

    public string? AContatto { get; set; }

    public string? AParteCol1 { get; set; }

    public string? BParteCol1 { get; set; }

    public string? Um { get; set; }

    public string? Posizione { get; set; }

    public string? Note { get; set; }

    public string? BCodArtFornitore { get; set; }

    public string? BCodColForn { get; set; }

    public int? TpOrd { get; set; }

    public int? AIdStag { get; set; }

    public string? Tp2 { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? FornPref { get; set; }

    public string? LabPrev { get; set; }

    public string? BParteMis { get; set; }

    public int? IdTipoMat { get; set; }

    public string? ATipoModello { get; set; }

    public bool? CkContr { get; set; }
}

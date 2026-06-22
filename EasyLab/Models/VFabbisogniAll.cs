using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VFabbisogniAll
{
    public int Id { get; set; }

    public int? Livello { get; set; }

    public int? AIdContatto { get; set; }

    public string? AContatto { get; set; }

    public int? IdStag { get; set; }

    public string Stato { get; set; } = null!;

    public string? Misura { get; set; }

    public double? FabbNetto { get; set; }

    public int? IdTesta { get; set; }

    public int? Seq { get; set; }

    public double? Cons { get; set; }

    public double? CapiFabbNetto { get; set; }

    public short? CapiFabbNettoMod { get; set; }

    public double? FabbLordi { get; set; }

    public double? CapiFabbLordi { get; set; }

    public string? ATipo { get; set; }

    public string? ACdAll { get; set; }

    public string? ACdAllcol { get; set; }

    public string? ACdAllmis { get; set; }

    public string? AStag { get; set; }

    public int? AIdStag { get; set; }

    public string? AParte { get; set; }

    public string? AParteDesc { get; set; }

    public string? AParteCol { get; set; }

    public string? AParteColDesc { get; set; }

    public string? AParteMis { get; set; }

    public string? AParteMisDesc { get; set; }

    public int? ACkMatMis { get; set; }

    public bool? ACkSemilav { get; set; }

    public string? AFornPref { get; set; }

    public string? ALabPrev { get; set; }

    public string? ACodArtFornitore { get; set; }

    public string? BTipo { get; set; }

    public string? BCdAll { get; set; }

    public string? BCdAllcol { get; set; }

    public string? BCdAllmis { get; set; }

    public int? BIdContatto { get; set; }

    public string? BParte { get; set; }

    public string? BParteDesc { get; set; }

    public int? BCkMatMis { get; set; }

    public bool? BCkSemilav { get; set; }

    public string? BParteCol { get; set; }

    public string? BParteColDesc { get; set; }

    public string? BParteMis { get; set; }

    public string? BParteMisDesc { get; set; }

    public string? BFornPref { get; set; }

    public string? BLabPrev { get; set; }

    public string? BCodArtFornitore { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? ModCol { get; set; }

    public int? IdMod { get; set; }
}

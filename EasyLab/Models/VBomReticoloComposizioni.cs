using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBomReticoloComposizioni
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public int Seq { get; set; }

    public string? CdUm { get; set; }

    public double? Cons { get; set; }

    public bool CkMp { get; set; }

    public bool CkMrp { get; set; }

    public bool CkFabb { get; set; }

    public string? Note { get; set; }

    public int? IdMod { get; set; }

    public string? Tp { get; set; }

    public string? Tp2 { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? IdMat { get; set; }

    public string? Stato { get; set; }

    public string? Tp3 { get; set; }

    public string? Mat { get; set; }

    public string? DescMat { get; set; }

    public int? IdFornitore { get; set; }

    public string? Fornitore { get; set; }

    public string? CodArtFornitore { get; set; }

    public int? IdComp1 { get; set; }

    public int? IdComp2 { get; set; }

    public int? IdComp3 { get; set; }

    public string? Comp1 { get; set; }

    public string? Comp2 { get; set; }

    public string? Comp3 { get; set; }

    public int? IdPos1 { get; set; }

    public int? IdPos2 { get; set; }

    public int? IdPos3 { get; set; }

    public string? Pos1 { get; set; }

    public string? Pos2 { get; set; }

    public string? Pos3 { get; set; }

    public int? Idlav1 { get; set; }

    public int? Idlav2 { get; set; }

    public int? Idlav3 { get; set; }

    public int? Idlav4 { get; set; }

    public int? Idlav5 { get; set; }

    public int? Idlav6 { get; set; }

    public string? Lav1 { get; set; }

    public string? Lav2 { get; set; }

    public string? Lav3 { get; set; }

    public string? Lav4 { get; set; }

    public string? Lav5 { get; set; }

    public string? Lav6 { get; set; }

    public int LavOrd1 { get; set; }

    public int LavOrd2 { get; set; }

    public int LavOrd3 { get; set; }

    public int LavOrd4 { get; set; }

    public int LavOrd5 { get; set; }

    public int LavOrd6 { get; set; }

    public string? Posizione { get; set; }
}

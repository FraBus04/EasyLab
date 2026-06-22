using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBom3ReticoloComposizioni
{
    public string ACdAll { get; set; } = null!;

    public int Id { get; set; }

    public int AIdContatto { get; set; }

    public int AIdStag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public int Seq { get; set; }

    public string? CdUm { get; set; }

    public double Cons { get; set; }

    public bool CkMp { get; set; }

    public bool CkMrp { get; set; }

    public bool CkFabb { get; set; }

    public string Note { get; set; } = null!;

    public int? IdMod { get; set; }

    public string Tp { get; set; } = null!;

    public string Tp2 { get; set; } = null!;

    public int? IdMat { get; set; }

    public string Stato { get; set; } = null!;

    public string Tp3 { get; set; } = null!;

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

    public string Posizione { get; set; } = null!;

    public string? CompProd1 { get; set; }

    public string? CompProd2 { get; set; }

    public string? CompProd3 { get; set; }

    public string? CompProd4 { get; set; }

    public string? CompProd5 { get; set; }

    public string? PosProd1 { get; set; }

    public string? PosProd2 { get; set; }

    public string? PosProd3 { get; set; }

    public string? PosProd4 { get; set; }

    public string? PosProd5 { get; set; }

    public string? LavProd1 { get; set; }

    public string? LavProd2 { get; set; }

    public string? LavProd3 { get; set; }

    public string? LavProd4 { get; set; }

    public string? LavProd5 { get; set; }

    public string? LavProd6 { get; set; }

    public byte[]? ImmagineMod { get; set; }

    public string? Stag { get; set; }

    public bool? CkComp { get; set; }

    public string? Nome { get; set; }

    public string? GenderDesc { get; set; }

    public string? CatMercDesc { get; set; }

    public string? StagDesc { get; set; }

    public string? Mid { get; set; }

    public string? StatoMod { get; set; }

    public bool? CkOrigAnimale { get; set; }

    public string? DocCaptiv { get; set; }

    public string? DocNomeCom { get; set; }

    public string? DocNomeSci { get; set; }

    public string? DocProveni { get; set; }

    public string? Lav0NotaAgg { get; set; }

    public string? FaseDesc { get; set; }

    public int Ver { get; set; }
}

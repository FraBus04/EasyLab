using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiModelliEticCare1
{
    public int Id { get; set; }

    public string? Stag { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public bool? CkComp { get; set; }

    public string? EtiRich { get; set; }

    public byte[]? Immagine { get; set; }

    public string? Comp1 { get; set; }

    public string? Comp2 { get; set; }

    public string? Comp3 { get; set; }

    public string? Comp4 { get; set; }

    public string? Comp5 { get; set; }

    public string? Contatto { get; set; }

    public string? Kw { get; set; }

    public string? VociDoganali { get; set; }

    public string? VociDoganaliDesc { get; set; }

    public string? CatMerc { get; set; }

    public int? IdComp { get; set; }

    public int? Ord { get; set; }

    public int? Perc { get; set; }

    public string? Lang { get; set; }

    public int? IdFibra { get; set; }

    public string? Fibra { get; set; }

    public int? IdPos { get; set; }

    public int? IdMod { get; set; }

    public string? NotaStag { get; set; }

    public string? Lav0NotaAgg { get; set; }

    public string? Lav0NotaAggEn { get; set; }

    public string? Lav0NotaAggRu { get; set; }
}

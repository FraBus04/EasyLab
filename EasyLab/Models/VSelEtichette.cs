using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VSelEtichette
{
    public int Id { get; set; }

    public int IdUtente { get; set; }

    public int IdContatto { get; set; }

    public int Modo { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public string? StagCod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public string? Ean { get; set; }

    public int? Nr { get; set; }

    public string? Taglia { get; set; }

    public double? Pz1 { get; set; }

    public int? IdSet { get; set; }

    public int? OrdPm { get; set; }

    public string Comp1 { get; set; } = null!;

    public string Comp2 { get; set; } = null!;

    public string Comp3 { get; set; } = null!;

    public string Comp4 { get; set; } = null!;

    public string Comp5 { get; set; } = null!;

    public string Comp6 { get; set; } = null!;

    public string Comp7 { get; set; } = null!;

    public string Pos1 { get; set; } = null!;

    public string Pos2 { get; set; } = null!;

    public string Pos3 { get; set; } = null!;

    public string Pos4 { get; set; } = null!;

    public string Pos5 { get; set; } = null!;

    public string Pos6 { get; set; } = null!;

    public string Pos7 { get; set; } = null!;

    public string MadeIn { get; set; } = null!;

    public string? Lav1 { get; set; }

    public string? Lav2 { get; set; }

    public string? Lav3 { get; set; }

    public string? Lav4 { get; set; }

    public string? Lav5 { get; set; }

    public string? Lav6 { get; set; }

    public string? Nota { get; set; }
}

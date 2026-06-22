using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SelEtichetteComp
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

    public string? Comp1 { get; set; }

    public string? Comp2 { get; set; }

    public string? Comp3 { get; set; }

    public string? Comp4 { get; set; }

    public string? Comp5 { get; set; }

    public string? Comp6 { get; set; }

    public string? Comp7 { get; set; }

    public string? Pos1 { get; set; }

    public string? Pos2 { get; set; }

    public string? Pos3 { get; set; }

    public string? Pos4 { get; set; }

    public string? Pos5 { get; set; }

    public string? Pos6 { get; set; }

    public string? Pos7 { get; set; }

    public string? MadeIn { get; set; }

    public string? Lav1 { get; set; }

    public string? Lav2 { get; set; }

    public string? Lav3 { get; set; }

    public string? Lav4 { get; set; }

    public string? Lav5 { get; set; }

    public string? Lav6 { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SelEtichette
{
    public int Id { get; set; }

    public int IdUtente { get; set; }

    public int IdContatto { get; set; }

    public int Modo { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

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

    public double? Pz2 { get; set; }

    public string? Nota { get; set; }

    public int? IdDoc { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiMaterialiColori
{
    public string? Tipo { get; set; }

    public int IdContatto { get; set; }

    public int Id { get; set; }

    public string? CdAllcol { get; set; }

    public string? CdAll { get; set; }

    public string? Mat { get; set; }

    public string CodCol { get; set; } = null!;

    public string DescCol { get; set; } = null!;

    public string? CodColForn { get; set; }

    public string? PathImg { get; set; }

    public string? Nota { get; set; }

    public int IdMat { get; set; }

    public string? DescMat { get; set; }

    public string? ColEsteso { get; set; }

    public bool Enabled { get; set; }

    public string? CodArtFornitore { get; set; }

    public double? Pz { get; set; }

    public bool? CkMatMis { get; set; }

    public string? Forn { get; set; }

    public int? IdFornitore { get; set; }
}

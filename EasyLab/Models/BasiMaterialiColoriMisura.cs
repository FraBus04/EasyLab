using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiMaterialiColoriMisura
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdUte { get; set; }

    public int IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public string? Contatto { get; set; }

    public byte[]? ContattoImg { get; set; }

    public string? Um { get; set; }

    public string Mat { get; set; } = null!;

    public string? Forn { get; set; }

    public string? CodArtFornitore { get; set; }

    public string? DescMat { get; set; }

    public string? MatCol { get; set; }

    public string? MatColDesc { get; set; }

    public string? MatColCodForn { get; set; }

    public string? MatColNota { get; set; }

    public bool? MatColEnab { get; set; }

    public string? MatMis { get; set; }

    public string? MatMisDesc { get; set; }

    public string? MatMisCodForn { get; set; }

    public string? MatMisNota { get; set; }

    public string? CdValuta { get; set; }

    public double? MatPz { get; set; }

    public double? MatMisPz { get; set; }

    public string? MatColOrd { get; set; }
}

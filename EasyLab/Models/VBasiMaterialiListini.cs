using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiMaterialiListini
{
    public int Id { get; set; }

    public int IdTipo { get; set; }

    public string? Tipo { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public string? Mat { get; set; }

    public string? MatDesc { get; set; }

    public string? MatCol { get; set; }

    public string? MatColDesc { get; set; }

    public string? MatMis { get; set; }

    public string? MatMisDesc { get; set; }

    public int IdStag { get; set; }

    public bool? CkListSk { get; set; }

    public string? Stag { get; set; }

    public int IdForn { get; set; }

    public string? Forn { get; set; }

    public DateOnly? ValidDa { get; set; }

    public DateOnly? ValidA { get; set; }

    public double? QtDa { get; set; }

    public double? QtA { get; set; }

    public string CdValuta { get; set; } = null!;

    public double Pz { get; set; }

    public string? Nota { get; set; }

    public bool Enabled { get; set; }
}

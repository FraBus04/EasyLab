using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiMaterialiListini
{
    public int Id { get; set; }

    public int IdTipo { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public int IdStag { get; set; }

    public int IdForn { get; set; }

    public bool? CkListSk { get; set; }

    public DateOnly? ValidDa { get; set; }

    public DateOnly? ValidA { get; set; }

    public double? QtDa { get; set; }

    public double? QtA { get; set; }

    public string CdValuta { get; set; } = null!;

    public decimal Pz { get; set; }

    public string? Nota { get; set; }

    public bool Enabled { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }
}

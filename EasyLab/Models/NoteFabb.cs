using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class NoteFabb
{
    public string? Mat { get; set; }

    public string? ArticoloForn { get; set; }

    public string? Descrizione { get; set; }

    public string? MatCol { get; set; }

    public string? MatMis { get; set; }

    public double? Mag { get; set; }

    public double? Fabb { get; set; }

    public double? DaPrel { get; set; }

    public double? InOrd { get; set; }

    public string? DataPrev { get; set; }

    public double? Saldo { get; set; }

    public string? A { get; set; }

    public string? B { get; set; }

    public string? C { get; set; }

    public string? D { get; set; }

    public string? E { get; set; }

    public string? Nota1 { get; set; }

    public string? Nota2 { get; set; }

    public string? Stato { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public bool? CkMatMis { get; set; }
}

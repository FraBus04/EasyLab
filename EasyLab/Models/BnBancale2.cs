using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BnBancale2
{
    public string Fornitore { get; set; } = null!;

    public string Materiale { get; set; } = null!;

    public string ArticoloForn { get; set; } = null!;

    public string Descrizione { get; set; } = null!;

    public string CodCol { get; set; } = null!;

    public string? Misura { get; set; }

    public string DescCol { get; set; } = null!;

    public double Mag { get; set; }

    public string Prezzi { get; set; } = null!;

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public bool? CkErr { get; set; }

    public bool? CkMatMis { get; set; }

    public bool? CkRigaMat { get; set; }

    public string? Chiave { get; set; }
}

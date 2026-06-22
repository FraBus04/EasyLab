using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BnFabb
{
    public int Id { get; set; }

    public string? Fornitore { get; set; }

    public string? Materiale { get; set; }

    public string? ArticoloForn { get; set; }

    public string? Descrizione { get; set; }

    public string? CodCol { get; set; }

    public string? Misura { get; set; }

    public string? DescCol { get; set; }

    public string? Mag { get; set; }

    public string? FabbNetto { get; set; }

    public string? DaPrel { get; set; }

    public string? InOrd { get; set; }

    public string? DataPrev { get; set; }

    public string? Saldo { get; set; }

    public string? GreggioATerra { get; set; }

    public string? DaBonadiman { get; set; }

    public string? DaOrdinare { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public bool? CkErr { get; set; }

    public bool? CkRigaMat { get; set; }

    public bool? CkMatMis { get; set; }

    public int? IdMat { get; set; }

    public string? Chiave { get; set; }
}

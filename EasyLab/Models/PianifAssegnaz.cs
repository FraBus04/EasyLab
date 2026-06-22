using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class PianifAssegnaz
{
    public int Id { get; set; }

    public int? IdTesta { get; set; }

    public int IdRiga { get; set; }

    public int IdMod { get; set; }

    public int IdModCol { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public string Tipo { get; set; } = null!;

    public double Qta { get; set; }

    public DateOnly? DataDisp { get; set; }

    public int CkMat { get; set; }

    public int CkDataOrd { get; set; }

    public double? SaldoMat { get; set; }

    public double? FabbMat { get; set; }

    public double? QtaMat { get; set; }

    public int? QtaCapi { get; set; }
}

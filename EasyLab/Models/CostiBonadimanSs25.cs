using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class CostiBonadimanSs25
{
    public string Materiale { get; set; } = null!;

    public double Costo { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public string? Mat { get; set; }

    public string? MatCol { get; set; }

    public string? MatMis { get; set; }
}

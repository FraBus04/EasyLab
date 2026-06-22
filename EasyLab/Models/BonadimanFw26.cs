using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BonadimanFw26
{
    public string? CodiceCliente { get; set; }

    public string? Mat { get; set; }

    public string? MatCol { get; set; }

    public string? MatMis { get; set; }

    public double Prz { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public bool? CkMatMis { get; set; }

    public bool? CkMatMisPlm { get; set; }

    public double? PrzMatPlm { get; set; }

    public bool? CkIgnora { get; set; }

    public bool? AggMat { get; set; }
}

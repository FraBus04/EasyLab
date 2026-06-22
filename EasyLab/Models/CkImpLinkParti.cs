using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class CkImpLinkParti
{
    public int? IdCataSync { get; set; }

    public string? Mat { get; set; }

    public string? Col { get; set; }

    public string? Mis { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public string? Descr { get; set; }

    public double? CostoSt { get; set; }

    public string? CodForn { get; set; }
}

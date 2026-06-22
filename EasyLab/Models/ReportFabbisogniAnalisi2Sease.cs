using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ReportFabbisogniAnalisi2Sease
{
    public string Mat { get; set; } = null!;

    public string? ColMat { get; set; }

    public string? Misura { get; set; }

    public string? NotaMatCol { get; set; }

    public string? NotaMatCol2 { get; set; }

    public string? NotaMatCol3 { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }
}

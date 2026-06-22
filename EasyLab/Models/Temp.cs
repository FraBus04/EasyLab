using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Temp
{
    public int? IdTesta { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public string? Tipo { get; set; }

    public DateOnly? DataDisp { get; set; }

    public double? Qta { get; set; }

    public int? CkMat { get; set; }

    public int? CkDataOrd { get; set; }

    public int? IdStag { get; set; }

    public int? OrdTipoMat { get; set; }

    public string? CdTipoMat { get; set; }
}

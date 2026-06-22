using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiMaterialiCq
{
    public int Id { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCq { get; set; }

    public bool? CkContr { get; set; }

    public double? RitX { get; set; }

    public double? RitY { get; set; }

    public DateOnly? DataMov { get; set; }

    public string? Nota { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

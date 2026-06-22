using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class PianifLanciRisorse
{
    public int Id { get; set; }

    public int IdTesta { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public string Tipo { get; set; } = null!;

    public double? Qta { get; set; }

    public double? QtaDisp { get; set; }

    public DateOnly? DataDisp { get; set; }

    public int? OrdPm1 { get; set; }

    public string? CdTipoMat { get; set; }

    public int? OrdTipoMat { get; set; }

    public int? OrdMod { get; set; }

    public int? OrdModCol { get; set; }

    public double? DaPrelevare { get; set; }

    public int? IdStag { get; set; }

    public bool? CkDataOrd { get; set; }

    public DateOnly? DataOrdFirst { get; set; }

    public DateTime? DataIns { get; set; }

    public int? IdUteIns { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiMaterialiMisura
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string Mat { get; set; } = null!;

    public string Misura { get; set; } = null!;

    public string? DescMis { get; set; }

    public string? DescMisForn { get; set; }

    public string? PathImg { get; set; }

    public string? Nota { get; set; }

    public double? Pz { get; set; }

    public double? PzCamp { get; set; }

    public int IdMat { get; set; }

    public bool Enab { get; set; }

    public int? PosMisSl { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? CdAll { get; set; }

    public int? OrdPm { get; set; }

    public string? Cd { get; set; }
}

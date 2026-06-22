using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiMaterialiMisura
{
    public int IdContatto { get; set; }

    public string Mat { get; set; } = null!;

    public string Misura { get; set; } = null!;

    public string? DescMis { get; set; }

    public string? DescMisForn { get; set; }

    public string? PathImg { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public string? Nota { get; set; }

    public double? Pz { get; set; }

    public int Id { get; set; }

    public int IdMat { get; set; }

    public string? DescMat { get; set; }

    public string? Forn { get; set; }

    public string? CodArtFornitore { get; set; }

    public bool Enab { get; set; }

    public int? IdUteUpd { get; set; }

    public string? Um { get; set; }

    public string? CdValuta { get; set; }
}

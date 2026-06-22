using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpTsePartiTemp3
{
    public int SyncUniqueid { get; set; }

    public string Parte { get; set; } = null!;

    public string CodicePosizione { get; set; } = null!;

    public string CodiceComposizione { get; set; } = null!;

    public string? Priorita { get; set; }

    public bool SyncEseguito { get; set; }

    public DateTime? SyncDataimport { get; set; }

    public DateTime? SyncDataexpcsv { get; set; }

    public int? SyncFlgeplm { get; set; }

    public int? IdMat { get; set; }

    public int? Pos { get; set; }

    public int? IdComp { get; set; }

    public int? IdPos { get; set; }

    public int? OrdImp { get; set; }

    public int? IdOrdPm { get; set; }

    public string? TimestampImp { get; set; }
}

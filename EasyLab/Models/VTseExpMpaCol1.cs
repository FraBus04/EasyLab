using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VTseExpMpaCol1
{
    public int SyncUniqueid { get; set; }

    public string ModelloParte { get; set; } = null!;

    public string Colore { get; set; } = null!;

    public string Stagione { get; set; } = null!;

    public bool AttivoDisattivo { get; set; }

    public bool SyncEseguito { get; set; }

    public DateTime? SyncDataimport { get; set; }

    public DateTime? SyncDataexpcsv { get; set; }

    public int? SyncFlgeplm { get; set; }

    public int? IdMod { get; set; }
}

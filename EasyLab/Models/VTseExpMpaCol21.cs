using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VTseExpMpaCol21
{
    public int SyncUniqueid { get; set; }

    public string ModelloParte { get; set; } = null!;

    public string Colore { get; set; } = null!;

    public string Stagione { get; set; } = null!;

    public bool AttivoDisattivo { get; set; }

    public bool SyncEseguito { get; set; }

    public DateTime? SyncDataimport { get; set; }

    public DateTime? SyncDataexpcsv { get; set; }

    public int? IdMod { get; set; }

    public int? SyncFlgeplm { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public int? IdStag { get; set; }
}

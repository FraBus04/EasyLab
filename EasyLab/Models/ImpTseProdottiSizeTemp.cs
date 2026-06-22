using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpTseProdottiSizeTemp
{
    public int Id { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string PianoTaglia { get; set; } = null!;

    public string Taglia { get; set; } = null!;

    public string AttivoDisattivo { get; set; } = null!;

    public int? IdSet { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? Ord { get; set; }

    public DateTime? DataImp { get; set; }

    public int? Lav { get; set; }

    public DateTime? DataLav { get; set; }

    public string? Error { get; set; }

    public int? IdTesta { get; set; }

    public int? SyncUniqueid { get; set; }

    public int? IdMod { get; set; }
}

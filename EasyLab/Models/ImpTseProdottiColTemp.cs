using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpTseProdottiColTemp
{
    public int Id { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string CodCol { get; set; } = null!;

    public int Stagione { get; set; }

    public string AttivoDisattivo { get; set; } = null!;

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public bool? Enabled { get; set; }

    public string? DescCol { get; set; }

    public DateTime? DataImp { get; set; }

    public int? Lav { get; set; }

    public DateTime? DataLav { get; set; }

    public string? Error { get; set; }

    public int? SyncUniqueid { get; set; }

    public int? IdTesta { get; set; }

    public int? IdModNoStag { get; set; }
}

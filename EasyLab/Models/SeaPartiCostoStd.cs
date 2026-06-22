using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SeaPartiCostoStd
{
    public string Parte { get; set; } = null!;

    public string Descrizione { get; set; } = null!;

    public string? CodiceArtFornitore { get; set; }

    public string ClasseMerceologica { get; set; } = null!;

    public string SottoclasseMerceologica { get; set; } = null!;

    public string? CostoStandard { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiAllsku
{
    public long IdSkuall { get; set; }

    public string? Tipo { get; set; }

    public string CdAll { get; set; } = null!;

    public string CdAllcol { get; set; } = null!;

    public string CdAllmis { get; set; } = null!;

    public string Lotto { get; set; } = null!;

    public string NrPezza { get; set; } = null!;

    public string? Parte { get; set; }

    public string? ParteDesc { get; set; }

    public string? ParteCol { get; set; }

    public string? ParteColDesc { get; set; }

    public string? ParteMis { get; set; }

    public string? ParteMisDesc { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public int? IdModNoStag { get; set; }

    public string? Um { get; set; }

    public int? IdSet { get; set; }

    public int? IdMod { get; set; }

    public int? IdMat { get; set; }

    public int? IdModCol { get; set; }

    public int? IdMatCol { get; set; }
}

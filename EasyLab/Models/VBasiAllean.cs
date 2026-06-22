using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiAllean
{
    public string? Tipo { get; set; }

    public string? CdEan { get; set; }

    public int IdEan { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public string? CdAll { get; set; }

    public string? CdAllcol { get; set; }

    public string? CdAllmis { get; set; }

    public string? Parte { get; set; }

    public string? ParteCol { get; set; }

    public string ParteMis { get; set; } = null!;

    public string? ParteDesc { get; set; }

    public string? ParteColDesc { get; set; }

    public string ParteMisDesc { get; set; } = null!;

    public string? ParteColMis { get; set; }

    public string? ParteColMisDesc { get; set; }

    public int IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int IdSetTaglia { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public string? Um { get; set; }

    public string? Stag { get; set; }

    public int? Enab { get; set; }

    public int IdSet { get; set; }
}

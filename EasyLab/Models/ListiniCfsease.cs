using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ListiniCfsease
{
    public string? Stag { get; set; }

    public int? CdTipoList { get; set; }

    public string? Sku { get; set; }

    public double? Prz { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModNoStag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public int? IdTipoList { get; set; }

    public double? PrzTse { get; set; }

    public bool? CkEsisteSk { get; set; }

    public int? CkErr { get; set; }

    public int? CkUguale { get; set; }

    public DateOnly? ValidDa { get; set; }

    public DateOnly? ValidA { get; set; }

    public int Id { get; set; }

    public int? CkErr2 { get; set; }
}

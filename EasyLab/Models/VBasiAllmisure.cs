using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiAllmisure
{
    public string Cd { get; set; } = null!;

    public string? CdAll { get; set; }

    public int IdContatto { get; set; }

    public string? Parte { get; set; }

    public string? ParteMis { get; set; }

    public string ParteMisDesc { get; set; } = null!;

    public string? DescMisForn { get; set; }

    public int? IdSetOrd { get; set; }

    public int? Enab { get; set; }

    public int IdMat { get; set; }

    public int? IdMatMis { get; set; }

    public int? IdSet { get; set; }

    public int? IdSetTg { get; set; }

    public int? IdSetGroup { get; set; }
}

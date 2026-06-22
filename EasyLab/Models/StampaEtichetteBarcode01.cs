using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class StampaEtichetteBarcode01
{
    public double Ean13 { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string CodCol { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string DescCol { get; set; } = null!;

    public string Qt { get; set; } = null!;

    public string StagProv { get; set; } = null!;

    public string? Season { get; set; }

    public string NewSku { get; set; } = null!;

    public int? IdMod { get; set; }

    public int? Modo { get; set; }
}

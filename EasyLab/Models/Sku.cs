using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Sku
{
    public string Sku1 { get; set; } = null!;

    public int? Esiste { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdStagMod { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ModCol { get; set; }
}

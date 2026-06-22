using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpListiniCf
{
    public int Id { get; set; }

    public int? IdContatto { get; set; }

    public int? IdTipoList { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? CodCol { get; set; }

    public double? Prz { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }
}

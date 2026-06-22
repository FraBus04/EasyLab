using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Fw26foreCast
{
    public int Id { get; set; }

    public string? Stag { get; set; }

    public string? Gender { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ModCol { get; set; }

    public byte? Qta { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }
}

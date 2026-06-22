using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiModelli2base
{
    public int IdContatto { get; set; }

    public int IdMod { get; set; }

    public int IdStag { get; set; }

    public string? Stag { get; set; }

    public string? StagDesc { get; set; }

    public string TipoModello { get; set; } = null!;

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string? Tg1 { get; set; }

    public string? Tg2 { get; set; }

    public string? Tg3 { get; set; }

    public string? Tg4 { get; set; }

    public string? Tg5 { get; set; }

    public string? Tg6 { get; set; }

    public string? Tg7 { get; set; }

    public string? Tg8 { get; set; }

    public string? Tg9 { get; set; }

    public string? Tg10 { get; set; }

    public string? Tg11 { get; set; }

    public string? PathImg { get; set; }
}

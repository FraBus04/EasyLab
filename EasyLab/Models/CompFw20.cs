using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class CompFw20
{
    public string? Column1 { get; set; }

    public string Codice { get; set; } = null!;

    public string Parte { get; set; } = null!;

    public string Articolo { get; set; } = null!;

    public string Colore { get; set; } = null!;

    public string Tessuto1 { get; set; } = null!;

    public string? Tessuto2 { get; set; }

    public string? T1 { get; set; }

    public string T2 { get; set; } = null!;

    public string? T3 { get; set; }

    public string? T4 { get; set; }

    public string? T5 { get; set; }

    public string SimboliLavaggio { get; set; } = null!;

    public string Simbolo1 { get; set; } = null!;

    public string Simbolo2 { get; set; } = null!;

    public string Simbolo3 { get; set; } = null!;

    public string Simbolo4 { get; set; } = null!;

    public string? Simbolo5 { get; set; }

    public string? Simbolo6 { get; set; }

    public string? Column20 { get; set; }

    public int? IdMod { get; set; }

    public int? IdLav1 { get; set; }

    public int? IdLav2 { get; set; }

    public int? IdLav3 { get; set; }

    public int? IdLav4 { get; set; }

    public int? IdLav5 { get; set; }

    public int? IdLav6 { get; set; }
}

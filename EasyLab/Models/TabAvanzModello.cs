using System;
using System.Collections.Generic;

namespace EasyLab.Models;

/// <summary>
/// 1 Modelli
/// 2 Prodotti
/// </summary>
public partial class TabAvanzModello
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public string Cod { get; set; } = null!;

    public string AvanzMod { get; set; } = null!;

    public int? OrdPm { get; set; }

    public string? AvanzModBreve { get; set; }

    public int? Colore { get; set; }

    public bool CkEnab { get; set; }

    public int AvanzPerc { get; set; }

    public byte[]? Immagine { get; set; }

    public string? PathImg { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? Colore2 { get; set; }

    public int? GgDa { get; set; }

    public int? GgA { get; set; }

    public int? DayAvanz { get; set; }

    public string? ColoreGant { get; set; }
}

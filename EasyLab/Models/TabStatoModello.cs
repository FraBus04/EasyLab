using System;
using System.Collections.Generic;

namespace EasyLab.Models;

/// <summary>
/// 1 Modelli
/// 2 Prodotti
/// </summary>
public partial class TabStatoModello
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string Tipo { get; set; } = null!;

    public string Cod { get; set; } = null!;

    public string StatoMod { get; set; } = null!;

    public int? OrdPm { get; set; }

    public string? StatoModBreve { get; set; }

    public int? Colore { get; set; }

    public bool CkEnab { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public byte[]? Immagine { get; set; }

    public string? PathImg { get; set; }
}

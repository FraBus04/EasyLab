using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabFasiLavorazione
{
    public int IdFase { get; set; }

    public string Cod { get; set; } = null!;

    public string Descr { get; set; } = null!;

    public string MatLav { get; set; } = null!;

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? OrdPm { get; set; }

    public int? Colore { get; set; }

    public string Tipo { get; set; } = null!;

    public double? TraspGg { get; set; }

    public int? Gg { get; set; }
}

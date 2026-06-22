using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabLinee2
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string Linea { get; set; } = null!;

    public string LineaDesc { get; set; } = null!;

    public string? PathImg { get; set; }

    public int? OrdPm { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabLinee
{
    public int IdLinea { get; set; }

    public int? IdContatto { get; set; }

    public string? Linea { get; set; }

    public string? LineaDesc { get; set; }

    public string? PathImg { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabUm
{
    public string Um { get; set; } = null!;

    public string Umdesc { get; set; } = null!;

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? Decimali { get; set; }
}

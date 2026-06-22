using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabStiro
{
    public int IdStiro { get; set; }

    public int IdContatto { get; set; }

    public string Descr { get; set; } = null!;

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

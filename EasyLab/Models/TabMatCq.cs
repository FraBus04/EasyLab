using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabMatCq
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public string Cod { get; set; } = null!;

    public string Descr { get; set; } = null!;

    public int? OrdPm { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

/// <summary>
/// 1&gt; Preventivo 2&gt;Calcolo Diba Val listino Mat 3&gt; ????
/// </summary>
public partial class TabTipoSk
{
    public int Id { get; set; }

    public string Cod { get; set; } = null!;

    public string? Descr { get; set; }

    public int? OrdPm { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? IdTipoCalcolo { get; set; }
}

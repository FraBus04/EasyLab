using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabSchedaTecnica
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdGruppo { get; set; }

    public string Desc1 { get; set; } = null!;

    public string? Descr2 { get; set; }

    public string? PathImg { get; set; }

    public int? StatoEdit { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? OrdPm { get; set; }
}

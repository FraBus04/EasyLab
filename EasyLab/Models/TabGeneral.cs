using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabGeneral
{
    public int Id { get; set; }

    public string Chiave { get; set; } = null!;

    public string? Cod { get; set; }

    public string? Descr { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

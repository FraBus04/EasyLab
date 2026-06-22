using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabDdtVettori
{
    public int Id { get; set; }

    public string? Vettore { get; set; }

    public string Stato { get; set; } = null!;

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? Cod { get; set; }
}

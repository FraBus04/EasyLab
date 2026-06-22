using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabVociDoganali
{
    public string Cod { get; set; } = null!;

    public string? Nota { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? Tipo { get; set; }
}

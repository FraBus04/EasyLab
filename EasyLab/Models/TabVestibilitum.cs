using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabVestibilitum
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string Cod { get; set; } = null!;

    public string? Descr { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

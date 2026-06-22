using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabFibre
{
    public int Id { get; set; }

    public string? Cod { get; set; }

    public string? Fibra { get; set; }

    public string? Italian { get; set; }

    public string? Francais { get; set; }

    public string? German { get; set; }

    public string? Polish { get; set; }

    public string? Spanish { get; set; }

    public string? Portuguese { get; set; }

    public string? Japan { get; set; }

    public string? Russian { get; set; }

    public string? NilornId { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

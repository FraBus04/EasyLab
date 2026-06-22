using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SettingDefault
{
    public string Chiave { get; set; } = null!;

    public int? IdDefault { get; set; }

    public string? CdDefault { get; set; }

    public DateOnly? DataDefault { get; set; }

    public bool? CkDefault { get; set; }

    public double? ValDefault { get; set; }
}

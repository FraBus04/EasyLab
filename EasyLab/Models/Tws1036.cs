using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Tws1036
{
    public string Item { get; set; } = null!;

    public string ModCol { get; set; } = null!;

    public string Tg { get; set; } = null!;

    public byte Qta { get; set; }

    public int? IdEan { get; set; }

    public string? Ean { get; set; }
}

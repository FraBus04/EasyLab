using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabBomTp3
{
    public int IdContatto { get; set; }

    public string Cod { get; set; } = null!;

    public string? Descr { get; set; }

    public int? OrdPm { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabTipoModello
{
    public string Tipo { get; set; } = null!;

    public string Descr { get; set; } = null!;

    public int? OrdPm { get; set; }
}

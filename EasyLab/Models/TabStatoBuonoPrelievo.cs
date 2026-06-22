using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabStatoBuonoPrelievo
{
    public string Cod { get; set; } = null!;

    public string Descr { get; set; } = null!;

    public int OrdPm { get; set; }
}

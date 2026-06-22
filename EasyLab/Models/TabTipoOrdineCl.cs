using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabTipoOrdineCl
{
    public string Cod { get; set; } = null!;

    public string Descr { get; set; } = null!;

    public int OrdPm { get; set; }

    public bool? CkImpegnaMag { get; set; }
}

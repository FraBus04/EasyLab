using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabStatoProdottoVenditum
{
    public string Cod { get; set; } = null!;

    public string Descr { get; set; } = null!;

    public int? Colore { get; set; }
}

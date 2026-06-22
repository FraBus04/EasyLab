using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class LauraReprice
{
    public string Style { get; set; } = null!;

    public string Col { get; set; } = null!;

    public string Size { get; set; } = null!;

    public string Qta { get; set; } = null!;

    public double Rprice { get; set; }

    public int Err { get; set; }

    public int Fefprice { get; set; }

    public string CodModParteSVarianti { get; set; } = null!;

    public double CodEanSVarianti { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Sofium
{
    public string Sku { get; set; } = null!;

    public double? ListWhl { get; set; }

    public double? ListRet { get; set; }

    public DateOnly? ValidDaWls { get; set; }

    public DateOnly? ValidDaRtl { get; set; }

    public double? ListRetAed { get; set; }

    public double? ListRetChf { get; set; }

    public DateOnly? ValidDaRtlaed { get; set; }

    public DateOnly? ValidDaRtlchf { get; set; }
}

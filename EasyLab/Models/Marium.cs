using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Marium
{
    public string SkuConfigurabile { get; set; } = null!;

    public int? IdStag { get; set; }

    public string? Sku { get; set; }

    public string? Tipo { get; set; }

    public string? Stag { get; set; }
}

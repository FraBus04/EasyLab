using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class StatoVendLaura
{
    public string Sku { get; set; } = null!;

    public string StatoVendibilit { get; set; } = null!;

    public int IdMatColNoStag { get; set; }

    public string? StatoPv { get; set; }
}

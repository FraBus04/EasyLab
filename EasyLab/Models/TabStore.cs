using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabStore
{
    public int Id { get; set; }

    public string Cod { get; set; } = null!;

    public string Descr { get; set; } = null!;

    public int? IdOrd { get; set; }

    public int? OrdPm { get; set; }
}

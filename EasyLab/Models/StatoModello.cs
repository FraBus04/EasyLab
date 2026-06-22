using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class StatoModello
{
    public int Id { get; set; }

    public string Cod { get; set; } = null!;

    public string StatoMod { get; set; } = null!;

    public int? OrdPm { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SpecItem
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public string? Cod { get; set; }

    public string Descr { get; set; } = null!;

    public int Ord { get; set; }
}

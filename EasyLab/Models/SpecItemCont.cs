using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SpecItemCont
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string Tipo { get; set; } = null!;

    public string Cod { get; set; } = null!;

    public string? Descr { get; set; }

    public int? OrdPm { get; set; }
}

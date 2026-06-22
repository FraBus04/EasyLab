using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiMaterialiLog
{
    public int Id { get; set; }

    public int IdMat { get; set; }

    public DateTime DataIns { get; set; }

    public int IdUteIns { get; set; }

    public string Attr { get; set; } = null!;

    public string? Prima { get; set; }

    public string? Dopo { get; set; }
}

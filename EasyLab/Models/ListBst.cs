using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ListBst
{
    public string? Nlist { get; set; }

    public string? Descr { get; set; }

    public string? Articolo { get; set; }

    public string? Desc1 { get; set; }

    public string? DataIniBs { get; set; }

    public string? DataFinBs { get; set; }

    public double? PrezzoBs { get; set; }

    public DateOnly? DataIniTse { get; set; }

    public DateOnly? DataFinTse { get; set; }

    public double? PrezzoTse { get; set; }
}

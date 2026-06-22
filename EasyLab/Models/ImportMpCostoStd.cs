using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImportMpCostoStd
{
    public string Parte { get; set; } = null!;

    public double? CostoStandard { get; set; }
}

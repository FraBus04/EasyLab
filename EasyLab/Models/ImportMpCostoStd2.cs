using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImportMpCostoStd2
{
    public string Parte { get; set; } = null!;

    public double? CostoStandard { get; set; }

    public double? CostoStandardOld { get; set; }
}

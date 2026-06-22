using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Gs1Matrice30
{
    public int Prefisso { get; set; }

    public DateOnly Data { get; set; }

    public int? MagTws { get; set; }

    public int? MagAll { get; set; }
}

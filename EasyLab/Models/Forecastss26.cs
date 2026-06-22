using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Forecastss26
{
    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string ModCol { get; set; } = null!;

    public byte Nr { get; set; }

    public int? IdModCol { get; set; }

    public int? Esiste { get; set; }
}

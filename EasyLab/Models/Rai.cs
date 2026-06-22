using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Rai
{
    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string ModCol { get; set; } = null!;

    public int? IdModColNoStag { get; set; }
}

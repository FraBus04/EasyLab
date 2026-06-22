using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class LinesheetStock0525
{
    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string Col { get; set; } = null!;

    public string Stockista { get; set; } = null!;

    public int? IdModCol { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdStag { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Fw25BuyingModelli
{
    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string ModCol { get; set; } = null!;

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModColNoStag { get; set; }
}

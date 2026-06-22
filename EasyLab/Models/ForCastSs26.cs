using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ForCastSs26
{
    public string Stag { get; set; } = null!;

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string ModCol { get; set; } = null!;

    public string Tg { get; set; } = null!;

    public byte Nr { get; set; }

    public byte PzArt { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }
}

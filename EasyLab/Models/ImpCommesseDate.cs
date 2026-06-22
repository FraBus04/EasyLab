using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpCommesseDate
{
    public int? Commessa { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Col { get; set; }

    public DateOnly? DataConfermata { get; set; }

    public int? IdComm { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdStag { get; set; }

    public bool? CkErr { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabMagazzini
{
    public string CodMag { get; set; } = null!;

    public string? CodMagDesc { get; set; }

    public bool MagDisp { get; set; }

    public int IdContatto { get; set; }

    public bool MagCalc { get; set; }

    public string? DaMag { get; set; }

    public string? Stato { get; set; }

    public bool? OkMov { get; set; }

    public bool? MagAssegn { get; set; }

    public string Tipo { get; set; } = null!;

    public bool? CkScaricoAssegn { get; set; }

    public bool? CkMagDistMp { get; set; }

    public bool? CkMagDistPf { get; set; }

    public string? Ragg { get; set; }
}

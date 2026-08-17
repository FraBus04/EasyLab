using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BuonoPrelievoMpSimRiga
{
    public string? BParte { get; set; }

    public string? BParteDesc { get; set; }

    public string? BParteCol { get; set; }

    public string? BParteColDesc { get; set; }

    public string? Um { get; set; }

    public double? Qta { get; set; }

    public double? MagNetto { get; set; }

    public double? MagLordo { get; set; }

    public double? FabbNetto { get; set; }

    public double? InOrd { get; set; }

    public DateOnly? DataArrOrd { get; set; }

    public string? CkDataConf { get; set; }

    public string? BContatto { get; set; }

    public string? CodArtFornitore { get; set; }

    public string? BCdAllCol { get; set; }
}

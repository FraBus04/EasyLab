using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VAnalisiFabbMagOrdCdTipoMat
{
    public int Id { get; set; }

    public int? IdTesta { get; set; }

    public int? Modo { get; set; }

    public string? CdTipoMat { get; set; }

    public string? TipoMat { get; set; }

    public double? FabbNetto { get; set; }

    public double? FabbLordi { get; set; }

    public double? MagNetto { get; set; }

    public double? OrdDaEvadere { get; set; }

    public double? MagUtile { get; set; }

    public double? PercMagUtile { get; set; }

    public double? OrdDaEvadereUtile { get; set; }

    public double? PercOrdDaEvadereUtile { get; set; }

    public string? ContattoMat { get; set; }

    public int? OrdPm { get; set; }

    public int? IdContatto { get; set; }

    public int? CapiFabbNetto { get; set; }

    public int? CapiFabbNetto1 { get; set; }

    public int? CapiFabbNetto2 { get; set; }

    public int? CapiFabbNetto3 { get; set; }

    public double? FabbNetto1 { get; set; }

    public double? FabbNetto2 { get; set; }

    public double? FabbNetto3 { get; set; }
}

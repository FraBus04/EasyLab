using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VAnalisiFabbMagOrd
{
    public int Id { get; set; }

    public int Modo { get; set; }

    public int Livello { get; set; }

    public string? ATipo { get; set; }

    public string? AContatto { get; set; }

    public string? AStag { get; set; }

    public string? ACdAll { get; set; }

    public string? ACdAllcol { get; set; }

    public string? ACdAllmis { get; set; }

    public int? ACkMatMis { get; set; }

    public bool? ACkSemilav { get; set; }

    public string? AParte { get; set; }

    public string? AParteDesc { get; set; }

    public string? AParteCol { get; set; }

    public string? AParteColDesc { get; set; }

    public string? AParteMis { get; set; }

    public string? AParteMisDesc { get; set; }

    public string? BTipo { get; set; }

    public string? BContatto { get; set; }

    public string BCdAll { get; set; } = null!;

    public string BCdAllcol { get; set; } = null!;

    public string BCdAllmis { get; set; } = null!;

    public string? BParte { get; set; }

    public string? BParteDesc { get; set; }

    public bool? BCkSemilav { get; set; }

    public int? BCkMatMis { get; set; }

    public string? BParteCol { get; set; }

    public string? BParteColDesc { get; set; }

    public bool? BParteColEnad { get; set; }

    public string? BParteMis { get; set; }

    public string? BParteMisDesc { get; set; }

    public int? BParteMisEnab { get; set; }

    public string? BFornitore { get; set; }

    public string? BLabPrev { get; set; }

    public string? BParteCodArtFornitore { get; set; }

    public int? BIdMat { get; set; }

    public int? BIdMatCol { get; set; }

    public int? BIdMatMis { get; set; }

    public string? BParteColMis { get; set; }

    public string? Um { get; set; }

    public double? MagNetto { get; set; }

    public double? MagLordo { get; set; }

    public double? OrdDaEvadere { get; set; }

    public double? CommDaEvadere { get; set; }

    public double? MagUtile { get; set; }

    public double? PercMagUtile { get; set; }

    public double? OrdDaEvadereUtile { get; set; }

    public double? PercOrdDaEvadereUtile { get; set; }

    public int? CkCoperto { get; set; }

    public string? CdTipoMat { get; set; }

    public double? Saldo { get; set; }

    public DateOnly? PrimaDataPrev { get; set; }

    public string? FlagConf { get; set; }

    public int? NrOrdiniAttivi { get; set; }

    public DateOnly? DataArrivoOrdini { get; set; }

    public bool? CkDataOrd { get; set; }

    public double? DaPrelevare { get; set; }

    public int? CapiFabbNetto { get; set; }

    public double? FabbNetto { get; set; }

    public double? FabbLordi { get; set; }

    public byte[]? ImgSl { get; set; }

    public string? BTp { get; set; }

    public string? BTpdesc { get; set; }

    public int? BTpordPm { get; set; }

    public string? Tm { get; set; }

    public string? Tmdescr { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? ALabPrev { get; set; }

    public string? ALinea { get; set; }

    public string? BCodColForn { get; set; }

    public int? BTmordPm { get; set; }
}

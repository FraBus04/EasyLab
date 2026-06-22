using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class AnalisiFabbMagOrd
{
    public int Id { get; set; }

    public int Livello { get; set; }

    public int Modo { get; set; }

    public string? ATipo { get; set; }

    public int? AIdContatto { get; set; }

    public string? ACdAll { get; set; }

    public string? ACdAllcol { get; set; }

    public string? ACdAllmis { get; set; }

    public int? BIdContatto { get; set; }

    public string? BTipo { get; set; }

    public string BCdAll { get; set; } = null!;

    public string BCdAllcol { get; set; } = null!;

    public string BCdAllmis { get; set; } = null!;

    public int? IdContatto { get; set; }

    public int? IdStag { get; set; }

    public int? IdTesta { get; set; }

    public bool? CkSemilav { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdLab { get; set; }

    public double? FabbNetto { get; set; }

    public double? FabbLordi { get; set; }

    public double? MagNetto { get; set; }

    public double? MagLordo { get; set; }

    public double? OrdDaEvadere { get; set; }

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

    public int? CapiFabbNetto1 { get; set; }

    public int? CapiFabbNetto2 { get; set; }

    public int? CapiFabbNetto3 { get; set; }

    public double? FabbNetto1 { get; set; }

    public double? FabbNetto2 { get; set; }

    public double? FabbNetto3 { get; set; }

    public double? PzMedioInOrd { get; set; }

    public double? PzInScheda { get; set; }

    public int? CapiFabbNettoMod { get; set; }

    public int? IdCanale { get; set; }

    public int? IdRagg1Ord { get; set; }

    public int? IdOrdPrimaDataPrev { get; set; }

    public double? FabbNettoTot { get; set; }

    public double? CommDaEvadere { get; set; }
}

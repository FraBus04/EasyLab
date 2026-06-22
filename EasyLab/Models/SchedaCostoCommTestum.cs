using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SchedaCostoCommTestum
{
    public int IdComm { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int IdMod { get; set; }

    public int TotCapiComm { get; set; }

    public int TotCapiProd { get; set; }

    public decimal? TotFasi { get; set; }

    public decimal? TotMatT { get; set; }

    public decimal? TotMatC { get; set; }

    public decimal? TotMatS { get; set; }

    public decimal? TotMatL { get; set; }

    public decimal? TotMatAltre { get; set; }

    public decimal? TotCostoFisso { get; set; }

    public double? Perc { get; set; }

    public decimal? TotCostoPerc { get; set; }

    public decimal? TotCosti { get; set; }

    public double? MarkUpEff { get; set; }

    public string? StatoApp { get; set; }

    public int? IdUteStatoApp { get; set; }

    public DateTime? DataApp { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataExp { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

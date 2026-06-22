using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class CollPlanItem
{
    public int Id { get; set; }

    public int IdCollTesta { get; set; }

    public int IdCollGroup { get; set; }

    public int IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdCol { get; set; }

    public int? IdModColCosto { get; set; }

    public decimal? TotFasi { get; set; }

    public decimal? TotMatT { get; set; }

    public decimal? TotMatC { get; set; }

    public decimal? TotMatS { get; set; }

    public decimal? TotMatL { get; set; }

    public decimal? TotImp { get; set; }

    public decimal? PercAddCosti { get; set; }

    public decimal? TotCostoFisso { get; set; }

    public decimal? MarkUpIni { get; set; }

    public string? Nota { get; set; }

    public string? StatoAppProd { get; set; }

    public string? StatoAppCol { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public DateTime? DataStatoApp { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }

    public int? IdUteApp { get; set; }

    public DateOnly? DataDa { get; set; }

    public DateOnly? DataA { get; set; }
}

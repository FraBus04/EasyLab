using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SchedaCostoTestum1
{
    public int IdTesta { get; set; }

    public int IdContatto { get; set; }

    public int IdTipoSk { get; set; }

    public string Stato { get; set; } = null!;

    public int IdMod { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? Linea { get; set; }

    public string? LineaDesc { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public decimal? TotFasi { get; set; }

    public decimal? TotMatT { get; set; }

    public decimal? TotMatC { get; set; }

    public decimal? TotCostoFisso { get; set; }

    public decimal? Perc { get; set; }

    public decimal? TotCostoPerc { get; set; }

    public decimal? TotCosti { get; set; }

    public decimal? MarkUpIni { get; set; }

    public decimal? MarkUpEff { get; set; }

    public string? Contatto { get; set; }

    public string? NotaMod { get; set; }

    public string? TagliaDa { get; set; }

    public string? TagliaA { get; set; }

    public string? TipoSk { get; set; }

    public string? TipoSkdesc { get; set; }

    public string? PathImgMod { get; set; }

    public decimal? TotCostoNetto { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

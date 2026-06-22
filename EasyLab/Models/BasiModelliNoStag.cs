using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiModelliNoStag
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public int? IdStagLast { get; set; }

    public int? IdModLast { get; set; }

    public int? IdVest { get; set; }

    public int? IdTabTipoManica { get; set; }

    public int? IdTabProdTess { get; set; }

    public int? Voto1 { get; set; }

    public int? Voto2 { get; set; }

    public int? Voto3 { get; set; }

    public int? Voto4 { get; set; }

    public int? Voto5 { get; set; }

    public int? Voto6 { get; set; }

    public int? Voto7 { get; set; }

    public int? Voto8 { get; set; }

    public int? Voto9 { get; set; }

    public string? PathImg { get; set; }

    public bool? CkSelWeb { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? IdStagionalita { get; set; }

    public int? IdCatMercMacro { get; set; }

    public int? IdCatMercMacro2 { get; set; }

    public int? IdCatMerc { get; set; }

    public int? IdCatMerc2 { get; set; }

    public string? DescCommerc { get; set; }

    public int? IdGender { get; set; }

    public int? IdGender2 { get; set; }

    public string? Nome { get; set; }

    public string? Guid { get; set; }

    public int? IdLinea { get; set; }

    public int? IdLinea2 { get; set; }
}

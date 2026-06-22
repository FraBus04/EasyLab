using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiModelliNoStag
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int? IdStagLast { get; set; }

    public int? IdModLast { get; set; }

    public string? LastStag { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public int? IdVest { get; set; }

    public string? Vestibilita { get; set; }

    public int? IdTabTipoManica { get; set; }

    public string? TipoManica { get; set; }

    public int? IdTabProdTess { get; set; }

    public string? ProdTess { get; set; }

    public string? PathImg { get; set; }

    public bool? CkSelWeb { get; set; }

    public string? Nome { get; set; }

    public int? Voto1 { get; set; }

    public int? Voto2 { get; set; }

    public int? Voto3 { get; set; }

    public int? Voto4 { get; set; }

    public int? Voto5 { get; set; }

    public int? Voto6 { get; set; }

    public int? Voto7 { get; set; }

    public int? Voto8 { get; set; }

    public int? Voto9 { get; set; }

    public string? CatMercMacro { get; set; }

    public string? CatMercMacro2 { get; set; }

    public string? CatMerc { get; set; }

    public string? CatMerc2 { get; set; }

    public string? DescCommerc { get; set; }

    public string? GenderCod { get; set; }

    public string? Stagionalita { get; set; }
}

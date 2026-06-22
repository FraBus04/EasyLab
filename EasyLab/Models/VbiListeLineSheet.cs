using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VbiListeLineSheet
{
    public int Id { get; set; }

    public int IdLista { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public string? MadeIn { get; set; }

    public string? Linea { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public string? CatMerc2Cod { get; set; }

    public string? CatMerc2Desc { get; set; }

    public string? CatMercMacroCod { get; set; }

    public string? CatMercMacroDesc { get; set; }

    public string? CatMercMacro2Cod { get; set; }

    public string? CatMercMacro2Desc { get; set; }

    public string? TgDa { get; set; }

    public int? TgDaPos { get; set; }

    public string? TgA { get; set; }

    public int? TgApos { get; set; }

    public string? LsheetCod { get; set; }

    public string? LsheetDesc { get; set; }

    public string? TipoModello { get; set; }

    public string? GenderCod { get; set; }

    public string? GenderDesc { get; set; }

    public string? Kw { get; set; }

    public string? Composizione { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class CfEanExp
{
    public int Id { get; set; }

    public string? Ean13 { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? CodCol { get; set; }

    public string? ScalBs { get; set; }

    public string? Nome { get; set; }

    public string? DescCol { get; set; }

    public string? Tg { get; set; }

    public string? CatMercMacroCod { get; set; }

    public string? CatMercMacroDesc { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public string? KitCod { get; set; }

    public string? KitDesc { get; set; }

    public string? Season { get; set; }

    public string? Stag { get; set; }

    public string? AnnoCod { get; set; }

    public int? Anno { get; set; }

    public string? Hscod { get; set; }

    public string? MidCod { get; set; }

    public string? CompCod { get; set; }

    public string? CompDesc { get; set; }

    public string? DescCommerc { get; set; }

    public string? ScalBsOld { get; set; }
}

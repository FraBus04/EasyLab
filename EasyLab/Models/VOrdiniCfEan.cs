using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VOrdiniCfEan
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int? IdOrd { get; set; }

    public int? IdRiga { get; set; }

    public int IdMod { get; set; }

    public int IdModCol { get; set; }

    public int IdSet { get; set; }

    public int IdSetTaglia { get; set; }

    public string Taglia { get; set; } = null!;

    public string? Ean { get; set; }

    public int Nr { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public string? OrdTipo { get; set; }

    public DateTime? OrdData { get; set; }

    public int? OrdNr { get; set; }

    public string? Po { get; set; }

    public string? Anag1 { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public string? Nome { get; set; }

    public string? MadeIn { get; set; }

    public string? Mid { get; set; }

    public string? HsCode { get; set; }

    public short? Peso { get; set; }

    public string? Gender { get; set; }

    public string? Kw { get; set; }

    public string? Op { get; set; }

    public string? CdTipoListino1 { get; set; }

    public string? TipoListinoDescr1 { get; set; }

    public string? CdTipoListino2 { get; set; }

    public string? TipoListinoDescr2 { get; set; }

    public string? CdTipoListino3 { get; set; }

    public string? TipoListinoDescr3 { get; set; }

    public string? CdTipoListino4 { get; set; }

    public string? TipoListinoDescr4 { get; set; }

    public string? CdTipoListino5 { get; set; }

    public string? TipoListinoDescr5 { get; set; }

    public string? CdTipoListino6 { get; set; }

    public string? TipoListinoDescr6 { get; set; }

    public string? CdTipoListino7 { get; set; }

    public string? TipoListinoDescr7 { get; set; }

    public string? CdTipoListino8 { get; set; }

    public string? TipoListinoDescr8 { get; set; }

    public double? Listino1 { get; set; }

    public double? Listino2 { get; set; }

    public double? Listino3 { get; set; }

    public double? Listino4 { get; set; }

    public double? Listino5 { get; set; }

    public double? Listino6 { get; set; }

    public double? Listino7 { get; set; }

    public double? Listino8 { get; set; }

    public double? PzArt { get; set; }

    public string? DescCommerc { get; set; }

    public string? Nota { get; set; }

    public string? Composizione { get; set; }

    public string? Composizione2 { get; set; }

    public string? Composizione3 { get; set; }

    public string? Composizione4 { get; set; }

    public string? Composizione5 { get; set; }

    public string? Pos1 { get; set; }

    public string? Pos2 { get; set; }

    public string? Pos3 { get; set; }

    public string? Pos4 { get; set; }

    public string? Pos5 { get; set; }
}

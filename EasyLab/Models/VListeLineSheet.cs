using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VListeLineSheet
{
    public int Id { get; set; }

    public int IdLista { get; set; }

    public int? IdContatto { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public string? MadeIn { get; set; }

    public string? VociDoganali { get; set; }

    public string? Linea { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public string? CatMerc2Cod { get; set; }

    public string? CatMerc2Desc { get; set; }

    public string? CatMercMacroCod { get; set; }

    public string? CatMercMacroDesc { get; set; }

    public string? CatMercMacro2Cod { get; set; }

    public string? CatMercMacro2Desc { get; set; }

    public string? Tg1 { get; set; }

    public string? Tg2 { get; set; }

    public string? Tg3 { get; set; }

    public string? Tg4 { get; set; }

    public string? Tg5 { get; set; }

    public string? Tg6 { get; set; }

    public string? Tg7 { get; set; }

    public string? Tg8 { get; set; }

    public string? Tg9 { get; set; }

    public string? Tg10 { get; set; }

    public string? Tg11 { get; set; }

    public double? List { get; set; }

    public int? IdSet { get; set; }

    public string? TgDa { get; set; }

    public int? TgDaPos { get; set; }

    public string? TgA { get; set; }

    public int? TgApos { get; set; }

    public string? LsheetCod { get; set; }

    public string? LsheetDesc { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public string? ListCod { get; set; }

    public string? ListDesc { get; set; }

    public string? TipoModello { get; set; }

    public string? Mid { get; set; }

    public short? Peso { get; set; }

    public short? IdGender { get; set; }

    public string? GenderCod { get; set; }

    public string? GenderDesc { get; set; }

    public string? Kw { get; set; }

    public string? Composizione { get; set; }

    public string? CompEstesa { get; set; }

    public string? DescCommerc { get; set; }

    public string? Vest { get; set; }

    public string? Op { get; set; }

    public string? PathImgMod { get; set; }

    public string? PathImgCol { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdStagMod { get; set; }

    public string? StatoPv { get; set; }

    public bool? Enab { get; set; }

    public string? StagTesta { get; set; }

    public int? IdCatMercMacro2 { get; set; }

    public int? IdCatMerc2 { get; set; }

    public int? OrdPmmacro { get; set; }

    public int? OrdPmmacro2 { get; set; }

    public int? OrdPmcatMerc { get; set; }

    public int? OrdPmcatMerc2 { get; set; }

    public int? OrdPm { get; set; }

    public string? L { get; set; }
}

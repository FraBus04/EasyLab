using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Modellari
{
    public int Id { get; set; }

    public int IdMod { get; set; }

    public string Stato { get; set; } = null!;

    public string? Contatto { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public string? Stag { get; set; }

    public string? StagDesc { get; set; }

    public string TipoModello { get; set; } = null!;

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string? GenderCod { get; set; }

    public string? GenderDesc { get; set; }

    public int? IdLinea { get; set; }

    public string? Linea { get; set; }

    public string? LineaDesc { get; set; }

    public int? IdCatMerc { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public int? IdModellista { get; set; }

    public string? Modellista { get; set; }

    public string? MadeIn { get; set; }

    public string? MadeInDesc { get; set; }

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

    public string? Lav1 { get; set; }

    public string? Lav2 { get; set; }

    public string? Lav3 { get; set; }

    public string? Lav4 { get; set; }

    public string? Lav5 { get; set; }

    public string? Lav6 { get; set; }

    public string? PathImgMod { get; set; }

    public string? PathImgCol { get; set; }

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

    public string? Tg12 { get; set; }

    public string? Tg13 { get; set; }

    public string? Tg14 { get; set; }

    public string? Tg15 { get; set; }

    public string? Tg16 { get; set; }

    public bool? CkTgEnab1 { get; set; }

    public bool? CkTgEnab2 { get; set; }

    public bool? CkTgEnab3 { get; set; }

    public bool? CkTgEnab4 { get; set; }

    public bool? CkTgEnab5 { get; set; }

    public bool? CkTgEnab6 { get; set; }

    public bool? CkTgEnab7 { get; set; }

    public bool? CkTgEnab8 { get; set; }

    public bool? CkTgEnab9 { get; set; }

    public bool? CkTgEnab10 { get; set; }

    public bool? CkTgEnab11 { get; set; }

    public bool? CkTgEnab12 { get; set; }

    public bool? CkTgEnab13 { get; set; }

    public bool? CkTgEnab14 { get; set; }

    public bool? CkTgEnab15 { get; set; }

    public bool? CkTgEnab16 { get; set; }

    public int? IdSetGroupTg1 { get; set; }

    public int? IdSetGroupTg2 { get; set; }

    public int? IdSetGroupTg3 { get; set; }

    public int? IdSetGroupTg4 { get; set; }

    public int? IdSetGroupTg5 { get; set; }

    public int? IdSetGroupTg6 { get; set; }

    public int? IdSetGroupTg7 { get; set; }

    public int? IdSetGroupTg8 { get; set; }

    public int? IdSetGroupTg9 { get; set; }

    public int? IdSetGroupTg10 { get; set; }

    public int? IdSetGroupTg11 { get; set; }

    public int? IdSetGroupTg12 { get; set; }

    public int? IdSetGroupTg13 { get; set; }

    public int? IdSetGroupTg14 { get; set; }

    public int? IdSetGroupTg15 { get; set; }

    public int? IdSetGroupTg16 { get; set; }

    public string? Kw { get; set; }

    public int? IdSet { get; set; }

    public string? Mid { get; set; }

    public string? DescCommerc { get; set; }

    public string? CatMercMacroCod { get; set; }

    public string? CatMercMacroDesc { get; set; }

    public string? StatoModCod { get; set; }

    public string? StatoMod { get; set; }

    public string? StatoModBreve { get; set; }

    public string? Cad { get; set; }

    public string? Nota { get; set; }

    public string? BaseProv { get; set; }

    public string? FilatoCucit { get; set; }

    public string? FilatoImp { get; set; }

    public string? TipoPunto { get; set; }

    public string? HsCode { get; set; }

    public string HsCodeDesc { get; set; } = null!;

    public string? Op { get; set; }

    public string? Stiro { get; set; }

    public string? Imballo { get; set; }

    public string? PathLogo { get; set; }

    public string? TagliaDa { get; set; }

    public string? TagliaA { get; set; }

    public string? TagliaBase { get; set; }

    public string? Trattamento { get; set; }

    public string? CatMercMacroCod2 { get; set; }

    public string? CatMercMacroDesc2 { get; set; }

    public string? CatMercCod2 { get; set; }

    public string? CatMercDesc2 { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public int? IdUte { get; set; }

    public int? IdModCol { get; set; }

    public double? PzGroup1 { get; set; }

    public double? PzGroup2 { get; set; }

    public double? PzGroup3 { get; set; }

    public double? PzGroup4 { get; set; }

    public string? CdMag { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VElencoProdotti
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public int IdStag { get; set; }

    public string? Stag { get; set; }

    public string? DescStag1 { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string? Linea { get; set; }

    public string? LineaDesc { get; set; }

    public string? Cad { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? IdTagliaBase { get; set; }

    public string? Nota { get; set; }

    public string? PathImg { get; set; }

    public string? BaseProv { get; set; }

    public bool? CkModello { get; set; }

    public string? NotaCostruz { get; set; }

    public string Stato { get; set; } = null!;

    public string? Modellista { get; set; }

    public string? CatMerc { get; set; }

    public string? Tg { get; set; }

    public string? CodSetTg { get; set; }

    public short? IdTagliaDa { get; set; }

    public short? IdTagliaA { get; set; }

    public string? DescSetTg { get; set; }

    public string? Trattamento { get; set; }

    public string StatoModCod { get; set; } = null!;

    public string StatoMod { get; set; } = null!;

    public string StatoModImg { get; set; } = null!;

    public string TipoModello { get; set; } = null!;

    public string? TipoPunto { get; set; }

    public string? TipoFilatoCucit { get; set; }

    public string? TipoFilatoImp { get; set; }

    public double? Listino { get; set; }

    public int? TotVend { get; set; }

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

    public int? MagSede { get; set; }

    public int? Assegnati { get; set; }

    public int? TotTag { get; set; }

    public int? TotSped { get; set; }

    public int? TotAnn { get; set; }

    public short? IdComp { get; set; }

    public string? Composizione { get; set; }

    public double? List1 { get; set; }

    public string? CatMercMacroCod { get; set; }

    public string? CatMercMacroDesc { get; set; }

    public string? DescCommerc { get; set; }

    public string? PathLogo { get; set; }

    public string? Lav1 { get; set; }

    public string? Lav2 { get; set; }

    public string? Lav3 { get; set; }

    public string? Lav4 { get; set; }

    public string? Lav5 { get; set; }

    public string? Lav6 { get; set; }

    public short? Peso { get; set; }

    public string? Kw { get; set; }

    public string? Op { get; set; }

    public string? MadeIn { get; set; }

    public string? Gender { get; set; }

    public string? HsCode { get; set; }

    public bool CkSemilav { get; set; }

    public int? IdCatMercMacro2 { get; set; }

    public string? CatMercMacroDesc2 { get; set; }

    public int? IdCatMerc2 { get; set; }

    public string? CatMerc2 { get; set; }

    public string? Vest { get; set; }

    public string? Stagionalita { get; set; }

    public int? IdCad { get; set; }

    public string? Mid { get; set; }

    public int? Idlav1 { get; set; }

    public int? Idlav2 { get; set; }

    public int? Idlav3 { get; set; }

    public int? Idlav4 { get; set; }

    public int? Idlav5 { get; set; }

    public int? Idlav6 { get; set; }

    public int? IdAvanzMod { get; set; }

    public string? AvanzModCod { get; set; }

    public string? AvanzMod { get; set; }

    public byte[]? AvanzModImg { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VElencoProdottiColori
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdSet { get; set; }

    public short? IdTagliaDa { get; set; }

    public short? IdTagliaA { get; set; }

    public string Stato { get; set; } = null!;

    public string? Contatto { get; set; }

    public string? Stag { get; set; }

    public string? DescStag1 { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public bool? ColEnab { get; set; }

    public string? Linea { get; set; }

    public string? LineaDesc { get; set; }

    public string? Nota { get; set; }

    public string? NotaCostruz { get; set; }

    public string? Modellista { get; set; }

    public string? CatMerc { get; set; }

    public string? Tg { get; set; }

    public string? CodSetTg { get; set; }

    public string? DescSetTg { get; set; }

    public string? Trattamento { get; set; }

    public string TipoModello { get; set; } = null!;

    public string? TipoPunto { get; set; }

    public string? TipoFilatoCucit { get; set; }

    public string? TipoFilatoImp { get; set; }

    public short? IdComp { get; set; }

    public string? Composizione { get; set; }

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

    public string? AvanzModDesc { get; set; }

    public byte[]? AvanzModImg { get; set; }

    public string? StatoApp { get; set; }

    public string? StatoAppDesc { get; set; }

    public string? NotaCol { get; set; }
}

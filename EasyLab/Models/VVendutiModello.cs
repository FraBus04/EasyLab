using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VVendutiModello
{
    public int IdMod { get; set; }

    public string Stato { get; set; } = null!;

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public int IdStag { get; set; }

    public string? Stag { get; set; }

    public string? StagDesc { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public string? Linea { get; set; }

    public string? LineaDesc { get; set; }

    public string? Nota { get; set; }

    public string? Cad { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? IdTagliaBase { get; set; }

    public string? PathImgMod { get; set; }

    public string? PathImgCol { get; set; }

    public string? CatMerc { get; set; }

    public int? CatMercOrdPm { get; set; }

    public string? CatMerc2 { get; set; }

    public int? CatMercOrdPm2 { get; set; }

    public string? CodSetTg { get; set; }

    public string? DescSetTg { get; set; }

    public int? OrdIdTagliaBase { get; set; }

    public string TipoModello { get; set; } = null!;

    public string? TipoPunto { get; set; }

    public string? TipoFilatoCucit { get; set; }

    public string? TipoFilatoImp { get; set; }

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

    public short? IdTagliaDa { get; set; }

    public short? IdTagliaA { get; set; }

    public int? Nr1 { get; set; }

    public int? Nr2 { get; set; }

    public int? Nr3 { get; set; }

    public int? Nr4 { get; set; }

    public int? Nr5 { get; set; }

    public int? Nr6 { get; set; }

    public int? Nr7 { get; set; }

    public int? Nr8 { get; set; }

    public int? Nr9 { get; set; }

    public int? Nr10 { get; set; }

    public int? Nr11 { get; set; }

    public int? Nr12 { get; set; }

    public int? Nr13 { get; set; }

    public int? Nr14 { get; set; }

    public int? Nr15 { get; set; }

    public int? Nr16 { get; set; }

    public int? TotCapi { get; set; }

    public int? IdModCol { get; set; }

    public bool? ColEnab { get; set; }

    public string? LabPrev { get; set; }

    public string? Fornit { get; set; }

    public string? LabPrevAnag2 { get; set; }

    public string? LabPrevVia { get; set; }

    public string? LabPrevCitta { get; set; }

    public string? LabPrevProv { get; set; }

    public string? LabPrevCap { get; set; }

    public string? ContattoSocieta2 { get; set; }

    public string? ContattoVia { get; set; }

    public string? ContattoCap { get; set; }

    public string? ContattoCitta { get; set; }

    public string? ContattoProv { get; set; }

    public string? ContattoEmail { get; set; }

    public string? ContattoTel { get; set; }

    public string? ContattoNota { get; set; }

    public string? MacroCatMerc { get; set; }

    public int? MacroCatMercOrdPm { get; set; }

    public string? MacroCatMerc2 { get; set; }

    public int? MacroCatMerc2OrdPm { get; set; }

    public string? Trattamento { get; set; }

    public int? IdCatMerc { get; set; }

    public int? IdCatMerc2 { get; set; }

    public int? IdCatMercMacro { get; set; }

    public int? IdCatMercMacro2 { get; set; }
}

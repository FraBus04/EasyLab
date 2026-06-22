using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzGeneOrdDaProdurre
{
    public string? Tipo { get; set; }

    public int IdRigaOrd { get; set; }

    public int Id { get; set; }

    public int IdTesta { get; set; }

    public string Stato { get; set; } = null!;

    public int IdStag { get; set; }

    public int IdContatto { get; set; }

    public string OrdTipo { get; set; } = null!;

    public int OrdNr { get; set; }

    public DateTime? OrdData { get; set; }

    public int Ccli { get; set; }

    public string? Anag1 { get; set; }

    public string? Citta { get; set; }

    public string? Nazione { get; set; }

    public int? ProgRiga { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public string Mod { get; set; } = null!;

    public string? Tess { get; set; }

    public string? ModCol { get; set; }

    public double? PzArt { get; set; }

    public short? Nr1 { get; set; }

    public short? Nr2 { get; set; }

    public short? Nr3 { get; set; }

    public short? Nr4 { get; set; }

    public short? Nr5 { get; set; }

    public short? Nr6 { get; set; }

    public short? Nr7 { get; set; }

    public short? Nr8 { get; set; }

    public short? Nr9 { get; set; }

    public short? Nr10 { get; set; }

    public short? Nr11 { get; set; }

    public short? Nr12 { get; set; }

    public short? Nr13 { get; set; }

    public short? Nr14 { get; set; }

    public short? Nr15 { get; set; }

    public short? Nr16 { get; set; }

    public int? TotCapi { get; set; }

    public int? IdOrd { get; set; }

    public int? IdLab { get; set; }

    public string? Lab { get; set; }

    public string? L { get; set; }

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

    public DateTime? Ts { get; set; }

    public string? Contatti { get; set; }

    public string? DescCol { get; set; }

    public string? PathImgMod { get; set; }

    public string? PathImgCol { get; set; }

    public string? Po { get; set; }

    public DateOnly? DataConsDa { get; set; }

    public DateOnly? DataConsA { get; set; }

    public string? Nome { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public byte[]? ImmagineMod1 { get; set; }

    public byte[]? ImmagineModCol1 { get; set; }

    public int? IdCanale { get; set; }

    public int? IdRagg1Ord { get; set; }
}

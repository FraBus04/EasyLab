using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VOrdiniClSellOut
{
    public int Id { get; set; }

    public int? IdOrd { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? StatoOrd { get; set; }

    public string? OrdTipo { get; set; }

    public int? OrdNr { get; set; }

    public int IdStag { get; set; }

    public string? Stag { get; set; }

    public int IdCcli { get; set; }

    public string? Anag1 { get; set; }

    public int IdMod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public int IdModCol { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public int Nr1 { get; set; }

    public int Nr2 { get; set; }

    public int Nr3 { get; set; }

    public int Nr4 { get; set; }

    public int Nr5 { get; set; }

    public int Nr6 { get; set; }

    public int Nr7 { get; set; }

    public int Nr8 { get; set; }

    public int Nr9 { get; set; }

    public int Nr10 { get; set; }

    public int Nr11 { get; set; }

    public int TotCapi { get; set; }

    public double? PzSell { get; set; }

    public DateOnly DataSell { get; set; }
}

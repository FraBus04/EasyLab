using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImportProduzGeneOrd
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdStag { get; set; }

    public int IdContatto { get; set; }

    public string OrdTipo { get; set; } = null!;

    public int OrdNr { get; set; }

    public DateTime? OrdData { get; set; }

    public int Ccli { get; set; }

    public int? CcliDest { get; set; }

    public string? RifIdContatto { get; set; }

    public DateTime? DataCons { get; set; }

    public string? StrVettore { get; set; }

    public string? StrPorto { get; set; }

    public string? StrPagamento { get; set; }

    public string? StrNota { get; set; }

    public string? DataPrevCons { get; set; }

    public double? Sco1 { get; set; }

    public int? IdAg { get; set; }

    public DateTime? DataConsDa { get; set; }

    public DateTime? DataConsA { get; set; }

    public string? Po { get; set; }

    public int? ProgRiga { get; set; }

    public int? IdMod { get; set; }

    public string Mod { get; set; } = null!;

    public string? Tess { get; set; }

    public string? Variante { get; set; }

    public string? ColOrd { get; set; }

    public string? CodProd { get; set; }

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

    public int? TotCapi { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? CdValuta { get; set; }

    public int? IdOrd { get; set; }

    public int? IdModCol { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzGeneOrdImpegnati
{
    public int Id { get; set; }

    public int IdRiga { get; set; }

    public int IdStag { get; set; }

    public int IdContatto { get; set; }

    public int? IdOrd { get; set; }

    public int? ProgRiga { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModColNoStag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? CodCol { get; set; }

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

    public int? IdUteIns { get; set; }

    public short? Nr12 { get; set; }

    public short? Nr13 { get; set; }

    public short? Nr14 { get; set; }

    public short? Nr15 { get; set; }

    public short? Nr16 { get; set; }
}

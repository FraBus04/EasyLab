using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzGeneOrdDaProdurreTotali
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public int IdContatto { get; set; }

    public int? IdComm { get; set; }

    public int? NrCommessa { get; set; }

    public int IdStag { get; set; }

    public int IdMod { get; set; }

    public int IdModCol { get; set; }

    public string Mod { get; set; } = null!;

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

    public string? DescCol { get; set; }

    public byte[]? ImgModCol { get; set; }

    public short? Nr12 { get; set; }

    public short? Nr13 { get; set; }

    public short? Nr14 { get; set; }

    public short? Nr15 { get; set; }

    public short? Nr16 { get; set; }
}

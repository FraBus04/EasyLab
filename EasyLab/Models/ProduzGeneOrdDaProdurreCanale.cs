using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzGeneOrdDaProdurreCanale
{
    public int Id { get; set; }

    public int IdCanale { get; set; }

    public string Stato { get; set; } = null!;

    public int IdStag { get; set; }

    public int IdContatto { get; set; }

    public string OrdTipo { get; set; } = null!;

    public int OrdNr { get; set; }

    public DateTime? OrdData { get; set; }

    public int Ccli { get; set; }

    public int? CcliDest { get; set; }

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

    public int? IdOrd { get; set; }

    public int? NrCommessa { get; set; }

    public int? IdRiga { get; set; }

    public int? IdModCol { get; set; }

    public DateTime? DataIns { get; set; }
}

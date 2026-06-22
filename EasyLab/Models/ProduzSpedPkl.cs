using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzSpedPkl
{
    public int Id { get; set; }

    public int IdPkltesta { get; set; }

    public int IdPklbox { get; set; }

    public int IdOrd { get; set; }

    public int IdStag { get; set; }

    public int IdContatto { get; set; }

    public int OrdNr { get; set; }

    public int IdRiga { get; set; }

    public string? CodUbic { get; set; }

    public string? CodMag { get; set; }

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

    public int Nr12 { get; set; }

    public int Nr13 { get; set; }

    public int Nr14 { get; set; }

    public int Nr15 { get; set; }

    public int Nr16 { get; set; }

    public int TotCapi { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MovimentiCforizz
{
    public int Id { get; set; }

    public int? IdTesta { get; set; }

    public string Stato { get; set; } = null!;

    public int IdMod { get; set; }

    public int IdModCol { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdComm { get; set; }

    public int? IdLista { get; set; }

    public int? IdDdtvend { get; set; }

    public int? IdRigaOrd { get; set; }

    public string? ModCol { get; set; }

    public string? CdMag { get; set; }

    public string? CodUbic { get; set; }

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

    public int? TotCapi { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? Nr12 { get; set; }

    public int? Nr13 { get; set; }

    public int? Nr14 { get; set; }

    public int? Nr15 { get; set; }

    public int? Nr16 { get; set; }
}

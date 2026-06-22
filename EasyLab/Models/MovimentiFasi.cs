using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MovimentiFasi
{
    public int Id { get; set; }

    public int? IdDoc { get; set; }

    public int? IdComm { get; set; }

    public DateOnly? DataMov { get; set; }

    public int? IdCausale { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdFaseComm { get; set; }

    public int? TotCapi { get; set; }

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

    public string? Nota { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? Saldo { get; set; }

    public DateOnly? DataRicRientro { get; set; }

    public DateOnly? DataConfRientro { get; set; }

    public bool? CkConfRientro { get; set; }

    public int? IdCcli { get; set; }

    public int? IdDocRiga { get; set; }

    public int? IdMov { get; set; }

    public double? PzArt { get; set; }

    public string? CdValuta { get; set; }

    public int? Nr16 { get; set; }

    public string? Lotto { get; set; }
}

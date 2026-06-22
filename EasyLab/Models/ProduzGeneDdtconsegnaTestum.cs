using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzGeneDdtconsegnaTestum
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int NrDoc { get; set; }

    public DateTime DataDoc { get; set; }

    public int? IdCcli { get; set; }

    public int? IdCcliDest { get; set; }

    public int OrdNr { get; set; }

    public string? Rif { get; set; }

    public int? NrColli { get; set; }

    public double? KgTot { get; set; }

    public string? Nota { get; set; }

    public int? TotCapi { get; set; }

    public double? TotVal { get; set; }

    public string? StrVettore { get; set; }

    public int? IdDdtCausale { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public int? IdDdtAspetto { get; set; }

    public bool? FlagGiaExp { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

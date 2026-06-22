using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MovimentiCfTestum
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdContatto { get; set; }

    public string? TipoDoc { get; set; }

    public int IdStag { get; set; }

    public int NrDoc { get; set; }

    public DateOnly DataDoc { get; set; }

    public int? IdCcli { get; set; }

    public int? IdCcliDest { get; set; }

    public int IdCausale1 { get; set; }

    public int IdCausale2 { get; set; }

    public int IdMov1 { get; set; }

    public int IdMov2 { get; set; }

    public string? CodMag1 { get; set; }

    public string? CodMag2 { get; set; }

    public int? IdOrd { get; set; }

    public bool Aperto { get; set; }

    public int? TotCapi { get; set; }

    public double? TotVal { get; set; }

    public string? CdValuta { get; set; }

    public int? NrColli { get; set; }

    public double? KgTot { get; set; }

    public string? Nota { get; set; }

    public int? IdDdtResa { get; set; }

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

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class OrdiniMpProposte
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int? IdStag { get; set; }

    public int IdFabb { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public double? FabbNetto { get; set; }

    public double? FabbLordi { get; set; }

    public DateTime? DataPrev { get; set; }

    public double? Prezzo { get; set; }

    public double? Sconto { get; set; }

    public string? Nota { get; set; }

    public double? MagNetto { get; set; }

    public double? MagLordo { get; set; }

    public double? DaPrelevare { get; set; }

    public double? OrdDaRicevere { get; set; }

    public int? NrOrdiniAttivi { get; set; }

    public DateOnly? PrimaDataPrev { get; set; }

    public int? CkCoperto { get; set; }

    public double? QtDaOrdinare { get; set; }

    public double? QtDaOrdinareEff { get; set; }

    public int? Multipli { get; set; }

    public double? Saldo { get; set; }

    public string? Modo { get; set; }

    public bool? CalcolaMagOrd { get; set; }

    public int? ModoProposta { get; set; }

    public bool? SoloDaOrdinare { get; set; }

    public int? IdLinea { get; set; }

    public int? ProgRiga { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? StatoApp { get; set; }

    public int? IdUteApp { get; set; }

    public DateTime? DateApp { get; set; }

    public bool? CalcolaOrd { get; set; }

    public bool? CalcolaMag { get; set; }

    public bool? CalcolaDaPrel { get; set; }
}

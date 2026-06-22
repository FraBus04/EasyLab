using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VWrkMovimentiMagazzinoTestum
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public DateOnly DataMov { get; set; }

    public int IdCausale { get; set; }

    public string? CodMagDa { get; set; }

    public string? CodMagA { get; set; }

    public string? NrDdt { get; set; }

    public DateOnly? DataDdt { get; set; }

    public int? CcliDdt { get; set; }

    public bool Aperto { get; set; }

    public int TotCapi { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? CausaleMovCod { get; set; }

    public string? CausaleMovDesc { get; set; }

    public string? Lab { get; set; }

    public string? Lab2 { get; set; }

    public string? Via { get; set; }

    public string? Cap { get; set; }

    public string? Citta { get; set; }

    public string? Nota { get; set; }

    public int? IdCausaleOpp { get; set; }

    public int? IdMov { get; set; }

    public int? IdMovOpp { get; set; }

    public string? CausaleMovOppCod { get; set; }

    public string? CausaleMovOppDesc { get; set; }

    public int? IdDdt { get; set; }

    public int? IdDdtCausale { get; set; }

    public string? Causale { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public string? TraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public string? Vettore { get; set; }

    public int? IdDdtAspetto { get; set; }

    public string? Aspetto { get; set; }

    public int? IdCcliDest { get; set; }

    public string? DestLab { get; set; }

    public string? DestLab2 { get; set; }

    public string? DestVia { get; set; }

    public string? DestCap { get; set; }

    public string? DestCitta { get; set; }

    public int? NrColli { get; set; }

    public double? KgTot { get; set; }

    public int? TotVal { get; set; }
}

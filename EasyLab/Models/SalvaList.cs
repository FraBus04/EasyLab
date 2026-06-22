using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SalvaList
{
    public string? NrOrdine { get; set; }

    public int? NrOrdineCliente { get; set; }

    public string? CodCliente { get; set; }

    public string? Cliente { get; set; }

    public string? CodFiliale { get; set; }

    public string? Pagamento { get; set; }

    public DateOnly? ConsegnaPrevista { get; set; }

    public DateOnly? DataLancio { get; set; }

    public string? CodArt { get; set; }

    public double? Prezzo { get; set; }

    public byte? Sconto { get; set; }

    public string? Sku { get; set; }

    public string? Taglia { get; set; }

    public double? Tg { get; set; }

    public byte? Qta { get; set; }

    public byte? QTOrdinata { get; set; }

    public bool? QTStornata { get; set; }

    public double? ValoreSconto { get; set; }

    public double? PrezzoConsPubbl { get; set; }

    public double? ValoreUnitario { get; set; }

    public double? TotaleValore { get; set; }

    public string? Column22 { get; set; }

    public string? Column23 { get; set; }

    public string? Column24 { get; set; }
}

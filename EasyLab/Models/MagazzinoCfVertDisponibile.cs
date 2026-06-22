using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MagazzinoCfVertDisponibile
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public string? CdMat { get; set; }

    public string? DescMat { get; set; }

    public string? CodArtFornitore { get; set; }

    public string? Lotto { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public string? CodColForn { get; set; }

    public string? Mis { get; set; }

    public double? Qta { get; set; }

    public int? IdForn { get; set; }

    public string? Forn { get; set; }

    public double? Fabb { get; set; }

    public double? DaPrelevare { get; set; }

    public double? OrdDaEvadere { get; set; }

    public DateOnly? DataArrivoOrdini { get; set; }

    public double? Saldo { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public decimal? Pz { get; set; }

    public decimal? PzMedio { get; set; }

    public string? CdMag { get; set; }

    public string? CdMagDesc { get; set; }

    public string? StagUtil { get; set; }
}

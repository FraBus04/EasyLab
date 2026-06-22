using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpListMpBonadiman
{
    public string? CodiceListino { get; set; }

    public string? Articolo { get; set; }

    public string? CodiceCliente { get; set; }

    public string? Descrizione { get; set; }

    public string? DescrizioneSupp { get; set; }

    public string? Um { get; set; }

    public string? Prezzo { get; set; }

    public string? InizioValidita { get; set; }

    public string? FineValidita { get; set; }

    public double? Pz { get; set; }

    public DateOnly? DataDa { get; set; }

    public DateOnly? DataA { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }
}

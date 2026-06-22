using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ListBonadiman
{
    public string? CodiceListino { get; set; }

    public string? Articolo { get; set; }

    public string? CodiceCliente { get; set; }

    public string? Descrizione { get; set; }

    public string? DescrizioneSupp { get; set; }

    public string? Um { get; set; }

    public double? Prezzo { get; set; }

    public DateOnly? InizioValidita { get; set; }

    public DateOnly? FineValidita { get; set; }
}

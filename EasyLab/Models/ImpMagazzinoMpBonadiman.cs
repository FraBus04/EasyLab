using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpMagazzinoMpBonadiman
{
    public string? Codice { get; set; }

    public string? CodiceCliente { get; set; }

    public string? Descrizione { get; set; }

    public string? DescrizioneSupplementare { get; set; }

    public string? UnitàDiMisura { get; set; }

    public string? Esistenza { get; set; }

    public string? Riservato { get; set; }

    public string? Impegnato { get; set; }

    public string? Ordinato { get; set; }

    public string? GiacenzaImpegnato { get; set; }

    public double? Giacenza { get; set; }
}

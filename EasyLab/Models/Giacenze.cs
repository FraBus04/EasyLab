using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Giacenze
{
    public string? CodiceArticolo { get; set; }

    public string? Modello { get; set; }

    public string? DescrizioneArticolo { get; set; }

    public string? UM { get; set; }

    public int? Quantit { get; set; }

    public string? DescrizioneMl { get; set; }

    public string? Colore { get; set; }

    public string? MagazzinoLogico { get; set; }
}

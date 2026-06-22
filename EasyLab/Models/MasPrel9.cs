using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MasPrel9
{
    public string CodiceArticolo { get; set; } = null!;

    public string Modello { get; set; } = null!;

    public string DescrizioneArticolo { get; set; } = null!;

    public string UM { get; set; } = null!;

    public int Quantit { get; set; }

    public string DescrizioneMl { get; set; } = null!;

    public string Colore { get; set; } = null!;

    public string TipoMateriale { get; set; } = null!;

    public int? Tipo { get; set; }
}

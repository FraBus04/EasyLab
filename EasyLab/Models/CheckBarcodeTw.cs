using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class CheckBarcodeTw
{
    public string Modello { get; set; } = null!;

    public string Colore { get; set; } = null!;

    public string Stagione { get; set; } = null!;

    public string Linea { get; set; } = null!;

    public string Taglia { get; set; } = null!;

    public long Barcode { get; set; }
}

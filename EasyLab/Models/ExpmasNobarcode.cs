using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ExpmasNobarcode
{
    public string Documento { get; set; } = null!;

    public string CodiceArticolo { get; set; } = null!;

    public string? Variante { get; set; }

    public string Barcode { get; set; } = null!;

    public string Flusso { get; set; } = null!;

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? CodCol { get; set; }

    public string? Tg { get; set; }

    public int? IdBarcode { get; set; }

    public bool? CkEantse { get; set; }
}

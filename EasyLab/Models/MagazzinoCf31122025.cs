using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MagazzinoCf31122025
{
    public string CodiceArticolo { get; set; } = null!;

    public string Variante { get; set; } = null!;

    public decimal GiacenzaNetta { get; set; }

    public decimal GiacenzaLorda { get; set; }

    public string Deposito { get; set; } = null!;

    public string? Barcode { get; set; }

    public string? Tipo { get; set; }
}

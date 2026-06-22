using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class HscodePe22
{
    public int HsCode { get; set; }

    public string CodModello { get; set; } = null!;

    public string CodParte { get; set; } = null!;

    public string ColorCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Color { get; set; } = null!;

    public string Scal { get; set; } = null!;

    public string? Description { get; set; }

    public string Categoria { get; set; } = null!;

    public string SubCategoria { get; set; } = null!;

    public string MicroCategory { get; set; } = null!;

    public string MagliaTessuto { get; set; } = null!;

    public string Composition { get; set; } = null!;

    public string? Column14 { get; set; }

    public string? Hsplm { get; set; }
}

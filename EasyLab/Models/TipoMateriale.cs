using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TipoMateriale
{
    public int Id { get; set; }

    public string TipoMat { get; set; } = null!;

    public string? Cod { get; set; }

    public string? Color { get; set; }

    public string? Path { get; set; }
}

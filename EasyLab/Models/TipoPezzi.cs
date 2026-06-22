using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TipoPezzi
{
    public int Id { get; set; }

    public string CodPezzo { get; set; } = null!;

    public string Pezzo { get; set; } = null!;

    public string? PezzoIng { get; set; }
}

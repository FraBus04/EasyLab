using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class WrkTabCausaleMagazzino
{
    public string CodCausale { get; set; } = null!;

    public string? CausaleDesc { get; set; }

    public short? Id { get; set; }
}

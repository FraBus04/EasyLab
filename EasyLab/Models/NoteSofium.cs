using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class NoteSofium
{
    public string Sku { get; set; } = null!;

    public string NomeModello { get; set; } = null!;

    public string DescrizioneMerchandising { get; set; } = null!;

    public int? IdMod { get; set; }
}

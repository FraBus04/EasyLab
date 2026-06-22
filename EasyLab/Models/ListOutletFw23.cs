using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ListOutletFw23
{
    public string Sku { get; set; } = null!;

    public int Eurofull { get; set; }

    public int Eurosc { get; set; }

    public DateOnly? ValidDa { get; set; }

    public DateOnly? ValidA { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class EanStock
{
    public long Gtin { get; set; }

    public string? DescrizioneProdotto { get; set; }

    public string? Note { get; set; }
}

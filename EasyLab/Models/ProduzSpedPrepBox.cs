using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzSpedPrepBox
{
    public int Id { get; set; }

    public int IdTestata { get; set; }

    public string Box { get; set; } = null!;

    public double? Peso { get; set; }
}

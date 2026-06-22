using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzSpedPrepDett
{
    public int Id { get; set; }

    public int IdTestata { get; set; }

    public string Box { get; set; } = null!;

    public int? IdModelloColore1 { get; set; }

    public int IdStag { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string Colore { get; set; } = null!;

    public int? IdSet { get; set; }

    public int? IdTaglia { get; set; }

    public string? Taglia { get; set; }

    public int? Ord { get; set; }

    public int? IdBox { get; set; }
}

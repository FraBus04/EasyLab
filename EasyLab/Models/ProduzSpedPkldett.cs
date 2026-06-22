using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzSpedPkldett
{
    public int Id { get; set; }

    public int IdPkltesta { get; set; }

    public int IdPklbox { get; set; }

    public int? IdEan { get; set; }

    public string Stag { get; set; } = null!;

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string ModCol { get; set; } = null!;

    public string Tg { get; set; } = null!;

    public string? CodUbic { get; set; }
}

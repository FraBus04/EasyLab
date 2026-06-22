using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzSpedPkldettEpc
{
    public int Id { get; set; }

    public int IdPkltesta { get; set; }

    public int IdPklbox { get; set; }

    public string Epc { get; set; } = null!;

    public int? IdEan { get; set; }
}

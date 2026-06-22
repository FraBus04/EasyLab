using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class PianifIlivelloMod
{
    public int Id { get; set; }

    public int IdTesta { get; set; }

    public int IdContatto { get; set; }

    public string? ATipo { get; set; }

    public string? ACdAll { get; set; }

    public int IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? TotCapi { get; set; }

    public int? OrdPianif { get; set; }

    public int? CkLancLe { get; set; }

    public int? PianifOrdMod { get; set; }
}

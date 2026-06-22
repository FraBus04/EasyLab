using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TempStampaSovraccollo
{
    public int Id { get; set; }

    public int? IdAnagForn { get; set; }

    public string? Anag1 { get; set; }

    public string? Anag2 { get; set; }

    public string? Via { get; set; }

    public string? Nciv { get; set; }

    public string? Cap { get; set; }

    public string? Citta { get; set; }

    public string? Prov { get; set; }

    public double? Peso { get; set; }

    public int? NrTotColli { get; set; }
}

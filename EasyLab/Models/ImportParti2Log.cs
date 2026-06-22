using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImportParti2Log
{
    public int Id { get; set; }

    public DateTime? Ts { get; set; }

    public string? Parte { get; set; }

    public string? ColAbilitatoCod { get; set; }

    public string? MisureAbilitateCod { get; set; }

    public string? FornPrefCod { get; set; }

    public string? FornDesc { get; set; }

    public string? CodColForn { get; set; }

    public string? CodMisForn { get; set; }

    public double? PrezzoLineato { get; set; }
}

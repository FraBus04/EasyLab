using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpTsePartiTemp2
{
    public int Id { get; set; }

    public int? SyncUniqueid { get; set; }

    public string? Parte { get; set; }

    public string? ColAbilitatoCod { get; set; }

    public string? FornPrefCod { get; set; }

    public string? CodColForn { get; set; }

    public string? MisureAbilitateCod { get; set; }

    public string? CodMisForn { get; set; }

    public double? PrezzoLineato { get; set; }

    public int? SyncEseguito { get; set; }

    public DateTime? SyncDataimport { get; set; }

    public DateTime? SyncDataexpcsv { get; set; }

    public int? SyncFlgeplm { get; set; }

    public bool? CkMatMis { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public int? IdFornitoreMat { get; set; }

    public int? IdFornitoreCol { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiMaterialiFornitori
{
    public int Id { get; set; }

    public int IdForn { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public string? CodArtFornitore { get; set; }

    public string? Umacq { get; set; }

    public short? Peso { get; set; }

    public short? PesoMtq { get; set; }

    public short? Hforn { get; set; }

    public short? Hutile { get; set; }

    public string? MinProd { get; set; }

    public string? LungPezze { get; set; }

    public int? MultOrd { get; set; }

    public int? LeadTimeGg { get; set; }

    public string? LeadTime { get; set; }

    public string? CdValuta { get; set; }

    public double? Pz { get; set; }

    public double? PzCamp { get; set; }

    public string? CodColForn { get; set; }

    public string? CodMisForn { get; set; }

    public bool? CkFornPref { get; set; }

    public int? PosMisSl { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

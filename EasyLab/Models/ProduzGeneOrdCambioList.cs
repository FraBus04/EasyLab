using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzGeneOrdCambioList
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdContatto { get; set; }

    public int? IdOrd { get; set; }

    public int IdStag { get; set; }

    public int IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public string OrdTipo { get; set; } = null!;

    public int OrdNr { get; set; }

    public DateOnly? OrdData { get; set; }

    public int Ccli { get; set; }

    public int? CcliDest { get; set; }

    public int? ProgRiga { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string? Variante { get; set; }

    public string? ColOrd { get; set; }

    public double? PzArt { get; set; }

    public int? TotCapi { get; set; }

    public string? CdValuta { get; set; }

    public double? Sco1 { get; set; }

    public double? PzArtList { get; set; }

    public string? CdValutaList { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? StagMod { get; set; }

    public string? Nome { get; set; }

    public double? PzArtLat { get; set; }
}

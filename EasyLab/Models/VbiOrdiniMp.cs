using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VbiOrdiniMp
{
    public int Id { get; set; }

    public string? StatoTesta { get; set; }

    public int IdTesta { get; set; }

    public string? Forn { get; set; }

    public string? NrOrd { get; set; }

    public string? TipoOrd { get; set; }

    public string? CdValuta { get; set; }

    public DateOnly? DataOrd { get; set; }

    public string? NotaTesta { get; set; }

    public string StatoRiga { get; set; } = null!;

    public int ProgRiga { get; set; }

    public string? Stag { get; set; }

    public string? Linea { get; set; }

    public string? Mat { get; set; }

    public string? DescMat { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public string? CodColForn { get; set; }

    public string? Misura { get; set; }

    public string? DescMis { get; set; }

    public string? DescMisForn { get; set; }

    public double QtOrd { get; set; }

    public double QtArr { get; set; }

    public string? CodMag { get; set; }

    public string FlagSaldo { get; set; } = null!;

    public DateTime? DataPrev { get; set; }

    public DateTime? DataArr { get; set; }

    public double? Prezzo { get; set; }

    public double? Sconto { get; set; }

    public string? FlagConf { get; set; }

    public double? QtDaConf { get; set; }

    public double? QtTotOrdAperto { get; set; }

    public double? QtTotDaRicevere { get; set; }

    public string? NotaRiga { get; set; }

    public string? FlagNota { get; set; }

    public string CdStatoOrdMp { get; set; } = null!;

    public string? Anag1 { get; set; }

    public string? Anag2 { get; set; }

    public string? Via { get; set; }

    public string? CapNew { get; set; }

    public string? Citta { get; set; }

    public string? Prov { get; set; }

    public string? Nazione { get; set; }

    public string? CodArtFornitore { get; set; }

    public int? LeadTimeGg { get; set; }

    public string? MinProd { get; set; }

    public string? LungPezze { get; set; }

    public string? CdTipoMat { get; set; }

    public bool? CkMatMis { get; set; }

    public double? ValOrd { get; set; }

    public string? StatoOrdMptesta { get; set; }

    public string? StatoOrdMpriga { get; set; }

    public double? PercArr { get; set; }

    public string? PagamentoCod { get; set; }

    public string? Pagamento { get; set; }

    public string? Po { get; set; }

    public int? FlagConfInt { get; set; }

    public string MatCol { get; set; } = null!;

    public string MatMis { get; set; } = null!;
}

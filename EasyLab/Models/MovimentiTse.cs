using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MovimentiTse
{
    public int Id { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdSet { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? IdSetOrd { get; set; }

    public int? IdEan { get; set; }

    public string? Ean { get; set; }

    public string? Nome { get; set; }

    public string TipoDoc { get; set; } = null!;

    public string? SottotipoDoc { get; set; }

    public string CodDocumento { get; set; } = null!;

    public string? CodDocumentoDesc { get; set; }

    public DateTime DataDoc { get; set; }

    public decimal? CliFor { get; set; }

    public string? EmailClente { get; set; }

    public string? RagioneSocialeAnagrafica { get; set; }

    public DateTime? DataCons { get; set; }

    public decimal? TotImponibile { get; set; }

    public decimal? TotIva { get; set; }

    public decimal? TotDocumento { get; set; }

    public string? PoJoor { get; set; }

    public string Dep { get; set; } = null!;

    public string? DescrizioneDeposito { get; set; }

    public string? RagioneSocialeAgentePref { get; set; }

    public string? Porto { get; set; }

    public string? CausTrasporto { get; set; }

    public string? Stagione { get; set; }

    public decimal? RigaDoc { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ModCol { get; set; }

    public string? ModColDesc { get; set; }

    public string? Tg { get; set; }

    public string? CodArticolo { get; set; }

    public string? VarianteColTg { get; set; }

    public string? DescrizioneArticolo { get; set; }

    public string? Segno { get; set; }

    public string? Um1 { get; set; }

    public decimal? Qta1Doc { get; set; }

    public decimal? Qta1Trasf { get; set; }

    public decimal? Qta1Res { get; set; }

    public decimal? PrezzoIva { get; set; }

    public decimal? Prezzo { get; set; }

    public decimal? Sc1 { get; set; }

    public decimal? Sc2 { get; set; }

    public decimal? ScontoMerce { get; set; }

    public decimal? ImportoRiga { get; set; }

    public string? Iva { get; set; }

    public string? AliquotaIvaEffettiva { get; set; }

    public DateTime? DataConsInt { get; set; }

    public string? DepRiga { get; set; }

    public string? TipoOmaggio { get; set; }

    public string? CodArtCliFor { get; set; }

    public decimal? CausaleDiMagazzino { get; set; }

    public string? DocOrigine { get; set; }
}

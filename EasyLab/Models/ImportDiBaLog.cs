using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImportDiBaLog
{
    public int Id { get; set; }

    public DateTime? Ts { get; set; }

    public string? Title { get; set; }

    public string? ColoreStg { get; set; }

    public int? Stagione { get; set; }

    public int? Seq { get; set; }

    public string? Tp { get; set; }

    public string? IdTessuto { get; set; }

    public string? Parte { get; set; }

    public string? Colore1 { get; set; }

    public string? DescrizioneColore { get; set; }

    public string? Misura { get; set; }

    public string? Udm { get; set; }

    public string? ConsumoACapoSingolo { get; set; }

    public double? Consumo1 { get; set; }

    public string? Pcns { get; set; }

    public string? Mp { get; set; }

    public string? Cos { get; set; }

    public string? Mrp { get; set; }

    public string? ClasseImpiego { get; set; }

    public string? Posizione { get; set; }

    public string? Note { get; set; }

    public string? Fornitore { get; set; }

    public string? AbbinamentoColori { get; set; }

    public string? AbbinamentoTaglie { get; set; }

    public string? NomeModello { get; set; }

    public string? Annullato { get; set; }

    public string? Dex { get; set; }

    public int? IdCataImp { get; set; }

    public int? IdMod { get; set; }

    public string? LastOrdImp { get; set; }
}

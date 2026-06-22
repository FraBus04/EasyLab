using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpMagazzinoMpMa
{
    public string CodiceArticolo { get; set; } = null!;

    public string? DescrizioneArticolo { get; set; }

    public string? Lotto { get; set; }

    public string? Variante1 { get; set; }

    public string? Variante2 { get; set; }

    public string? NumeroPallet { get; set; }

    public string? DescrizioneMf { get; set; }

    public string? DescrizioneMl { get; set; }

    public string? DataScadenza { get; set; }

    public string? DataIngresso { get; set; }

    public double? Quantità { get; set; }

    public string? Societa { get; set; }

    public string? Scaffale { get; set; }

    public string? Posizione { get; set; }

    public string? Piano { get; set; }

    public string? ScaffaleCorsia { get; set; }

    public int Id { get; set; }

    public string? Tipo { get; set; }
}

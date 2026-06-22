using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class DatiWeb
{
    public long? Ean13 { get; set; }

    public string? NewSku { get; set; }

    public string? SkuSize { get; set; }

    public string? CodModello { get; set; }

    public string? CodParte { get; set; }

    public string? Name { get; set; }

    public string? Color { get; set; }

    public string? Tg { get; set; }

    public string? Category { get; set; }

    public string? Microcategory { get; set; }

    public string? FitEn { get; set; }

    public string? FitIt { get; set; }

    public string? DescriptionEnShort { get; set; }

    public string? DescriptionItShort { get; set; }

    public string? TechFeatures { get; set; }

    public string? SustainableFeatures { get; set; }

    public string? Composition { get; set; }

    public string? Season { get; set; }

    public string? Anno { get; set; }

    public string? ModelwearsIt { get; set; }

    public string? ModelwearsEn { get; set; }

    public string? Modelwears2It { get; set; }

    public string? Modelwears2En { get; set; }

    public string? DescriptionItLong { get; set; }

    public string? DescriptionEnLong { get; set; }

    public double? Coeffvol { get; set; }

    public double? PriceEur { get; set; }

    public double? PriceUsd { get; set; }

    public double? PriceGbp { get; set; }

    public double? PriceChf { get; set; }
}

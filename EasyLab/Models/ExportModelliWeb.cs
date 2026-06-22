using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ExportModelliWeb
{
    public int? Id { get; set; }

    public string? ActiveIt { get; set; }

    public string? ActiveEn { get; set; }

    public string? ArtCode { get; set; }

    public string? NameIt { get; set; }

    public string? NameEn { get; set; }

    public string? UrlPartIt { get; set; }

    public string? UrlPartEn { get; set; }

    public string? SkuSize { get; set; }

    public long? Barcode { get; set; }

    public string? Color { get; set; }

    public string? Size { get; set; }

    public string? Active { get; set; }

    public string? Forcecatalogview { get; set; }

    public string? Priority { get; set; }

    public double? PriceEur { get; set; }

    public double? PriceUsd { get; set; }

    public double? PriceGbp { get; set; }

    public double? PriceChf { get; set; }

    public double? PriceplainEur { get; set; }

    public double? PriceplainUsd { get; set; }

    public double? PriceplainGbp { get; set; }

    public double? PriceplainChf { get; set; }

    public string? IsSaldi { get; set; }

    public long? BarcodeNew { get; set; }
}

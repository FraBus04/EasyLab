using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpBstModelliCk
{
    public long? Ean13 { get; set; }

    public string NewSku { get; set; } = null!;

    public string SkuSizeXIlWeb { get; set; } = null!;

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string CodCol { get; set; } = null!;

    public byte Scal { get; set; }

    public string Name { get; set; } = null!;

    public string? Color { get; set; }

    public string Tg { get; set; } = null!;

    public string? CategoryCode { get; set; }

    public string? Category { get; set; }

    public string? MicroCategoryCode { get; set; }

    public string? MicroCategory { get; set; }

    public string? KitCode { get; set; }

    public string? Kit { get; set; }

    public string? StagCode { get; set; }

    public string? Season { get; set; }

    public byte? AnnoCode { get; set; }

    public string? Anno { get; set; }

    public string? ModelWearsEng { get; set; }

    public string? ModelWearsIt { get; set; }

    public string? Fit { get; set; }

    public string? SkiCollection { get; set; }

    public string? DescriptionShort { get; set; }

    public string? DescriptionEnLong { get; set; }

    public string? DescriptionItLong { get; set; }

    public string? TechFeatures { get; set; }

    public string? SustainableFeatures { get; set; }

    public string? Composition { get; set; }

    public double Cog { get; set; }

    public double RetailPriceEuro { get; set; }

    public double RetailPriceChf { get; set; }

    public short RetailPriceUsd { get; set; }

    public short RetailPriceGbp { get; set; }

    public string? Quantity { get; set; }

    public string? InsertDateBst { get; set; }

    public string? DocNumberBst { get; set; }

    public string? DocTypeBst { get; set; }

    public string? CodiceDeposito { get; set; }

    public string? Status { get; set; }

    public string? CoefficienteVolumetrico { get; set; }

    public int? Qtstock { get; set; }

    public int? CkStockMod { get; set; }

    public string? SkuModello { get; set; }

    public int? IdModQt { get; set; }

    public int? Obsoleto { get; set; }

    public int? IdMod { get; set; }

    public int? CkEan { get; set; }

    public string? EanPm { get; set; }

    public int? Qt { get; set; }

    public string? EanStock { get; set; }

    public string? GruppoCod { get; set; }
}

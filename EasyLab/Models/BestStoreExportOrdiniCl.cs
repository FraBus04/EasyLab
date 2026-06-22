using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BestStoreExportOrdiniCl
{
    public string? Ean13 { get; set; }

    public string NewSku { get; set; } = null!;

    public string? SkuSizeXIlWeb { get; set; }

    public string CodModello { get; set; } = null!;

    public string CodParte { get; set; } = null!;

    public string ColCode { get; set; } = null!;

    public string? Scal { get; set; }

    public string? Name { get; set; }

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

    public string? AnnoCode { get; set; }

    public string? Anno { get; set; }

    public string? Description { get; set; }

    public string? TechFeatures { get; set; }

    public string? SustainableFeatures { get; set; }

    public string? CompositionCode { get; set; }

    public string? Composition { get; set; }

    public string? Cog { get; set; }

    public double? RetailPrice { get; set; }

    public int Quantity { get; set; }

    public string InsertDateBst { get; set; } = null!;

    public string DocNumberBst { get; set; } = null!;

    public string DocTypeBst { get; set; } = null!;

    public string CodiceDeposito { get; set; } = null!;

    public string? Status { get; set; }

    public string? CIva { get; set; }

    public int? NrCommessa { get; set; }

    public DateTime? DataCommessa { get; set; }

    public string? Laboratorio { get; set; }

    public int? IdOrd { get; set; }
}

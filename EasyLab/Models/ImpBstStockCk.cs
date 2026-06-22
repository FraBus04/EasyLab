using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpBstStockCk
{
    public string Deposito { get; set; } = null!;

    public string Descrizione { get; set; } = null!;

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string CodCol { get; set; } = null!;

    public string? Categoria { get; set; }

    public string? MicroCategoria { get; set; }

    public string? Composizione { get; set; }

    public byte? Anno { get; set; }

    public string? Stagione { get; set; }

    public string? Kit { get; set; }

    public long? HsCode { get; set; }

    public string? MidCode { get; set; }

    public string DescrArt { get; set; } = null!;

    public string SizeName { get; set; } = null!;

    public byte IndiceTag { get; set; }

    public long? Barcode { get; set; }

    public short Qta { get; set; }

    public string? SkuSizeXIlWeb { get; set; }

    public int? CkAnag { get; set; }

    public string? SkuModello { get; set; }
}

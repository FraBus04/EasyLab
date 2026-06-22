using System;
using System.Collections.Generic;

namespace EasyLab.Models;

/// <summary>
/// STOCK
/// LIBERO
/// </summary>
public partial class Setting
{
    public int IdContatto { get; set; }

    public double PercAddCosti { get; set; }

    public double? SchedaCostoCostoFisso { get; set; }

    public double? MarkUpIni { get; set; }

    public string? PathLogo { get; set; }

    public string? PathLogo2 { get; set; }

    public bool? CreaEan { get; set; }

    public string? CdMagAss { get; set; }

    public int? IdTipoListBase { get; set; }

    public bool? IsCompanyMaster { get; set; }

    public int? EanKey { get; set; }

    public string? EanDaDove { get; set; }
}

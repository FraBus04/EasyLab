using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BsExportCommesse
{
    public int IdMod { get; set; }

    public int NrScheda { get; set; }

    public DateOnly? DataComm { get; set; }

    public string? Forn { get; set; }

    public double TotCapi { get; set; }

    public long Ean13 { get; set; }

    public string CdMod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string CodCol { get; set; } = null!;

    public string Scal { get; set; } = null!;

    public string? Nome { get; set; }

    public string? DescCol { get; set; }

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

    public string? Hscode { get; set; }

    public string? Midcode { get; set; }

    public string? CdComposition { get; set; }

    public string? Composition { get; set; }
}

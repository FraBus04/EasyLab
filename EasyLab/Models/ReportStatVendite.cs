using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ReportStatVendite
{
    public int Id { get; set; }

    public int IdRetail { get; set; }

    public int IdStag { get; set; }

    public string IdMod { get; set; } = null!;

    public int IdModCol { get; set; }

    public int IdSet { get; set; }

    public string? CodMag { get; set; }

    public DateOnly? DataDa { get; set; }

    public DateOnly? DataA { get; set; }

    public int? Nr1 { get; set; }

    public int? Nr2 { get; set; }

    public int? Nr3 { get; set; }

    public int? Nr4 { get; set; }

    public int? Nr5 { get; set; }

    public int? Nr6 { get; set; }

    public int? Nr7 { get; set; }

    public int? Nr8 { get; set; }

    public int? Nr9 { get; set; }

    public int? Nr10 { get; set; }

    public int? Nr11 { get; set; }

    public int? TotCapi { get; set; }
}

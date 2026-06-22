using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class CollPlanGroup
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdCollTesta { get; set; }

    public int? IdCatMercMacro { get; set; }

    public int? IdCatMerc { get; set; }

    public int? IdCatMercMacro2 { get; set; }

    public int? IdCatMerc2 { get; set; }

    public string? Descr { get; set; }

    public int? PrzDa { get; set; }

    public int? PrzA { get; set; }

    public int? Qta { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public DateOnly? DataDa { get; set; }

    public DateOnly? DataA { get; set; }
}

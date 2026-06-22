using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VTabAvanzModelloCollPlan
{
    public int Id { get; set; }

    public int IdCollPlanGroup { get; set; }

    public int IdAvanzModello { get; set; }

    public DateOnly DataEnd { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? AvanzMod { get; set; }

    public int? Colore { get; set; }

    public int? AvanzPerc { get; set; }

    public int? OrdPm { get; set; }
}

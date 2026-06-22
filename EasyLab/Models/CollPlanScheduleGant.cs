using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class CollPlanScheduleGant
{
    public int Id { get; set; }

    public int? IdCollPlanTesta { get; set; }

    public int? IdCollPlanGroup { get; set; }

    public int? IdCatMercMacro { get; set; }

    public int? IdCatMerc { get; set; }

    public int? IdCatMercMacro2 { get; set; }

    public int? IdCatMerc2 { get; set; }

    public int? IdMod { get; set; }

    public int? IdAvanzMod { get; set; }

    public DateOnly? DataDa { get; set; }

    public DateOnly? DataA { get; set; }

    public DateOnly? DataDaDes { get; set; }

    public DateOnly? DataAdes { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class CollPlanAvanz
{
    public int Id { get; set; }

    public int IdCollTesta { get; set; }

    public int IdCollGroup { get; set; }

    public int IdMod { get; set; }

    public int IdAvanzMod { get; set; }

    public int? OrdPm { get; set; }

    public int? DayAvanz { get; set; }

    public DateOnly? DataDa { get; set; }

    public DateOnly? DataA { get; set; }

    public string? Predecessors { get; set; }
}

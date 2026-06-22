using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class CollPlanGant
{
    public int Id { get; set; }

    public int IdCollTesta { get; set; }

    public string? Livello { get; set; }

    public int IdCollGroup { get; set; }

    public int IdMod { get; set; }

    public int? IdParent { get; set; }

    public int? IdAvanzMod { get; set; }

    public int? IdCollAvanz { get; set; }

    public string? Descr { get; set; }

    public DateOnly? DateDa { get; set; }

    public DateOnly? DateA { get; set; }

    public DateOnly? DateDaProiezione { get; set; }

    public DateOnly? DateAproiezione { get; set; }

    public int? ColoreFase1 { get; set; }

    public int? ColoreFase2 { get; set; }

    public byte[]? ImgMod1 { get; set; }

    public string? Predecessors { get; set; }

    public string? Nota { get; set; }

    public double? Progress { get; set; }

    public int? IdContatto { get; set; }

    public string? ColoreGant { get; set; }

    public int? OrdPm { get; set; }
}

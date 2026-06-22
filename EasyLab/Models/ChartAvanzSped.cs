using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ChartAvanzSped
{
    public int Id { get; set; }

    public int? IdContatto { get; set; }

    public int? IdStag { get; set; }

    public DateOnly? Data { get; set; }

    public int? CapiQta { get; set; }

    public int? CapiQtaTot { get; set; }

    public string? MyColor { get; set; }

    public DateTime? DataIns { get; set; }

    public int? IdUteIns { get; set; }

    public string? Contatto { get; set; }

    public string? Stag { get; set; }

    public int? DesidQtaTot { get; set; }
}

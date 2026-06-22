using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ChartAvanzProduz1
{
    public int Id { get; set; }

    public int? IdTipoAvanz { get; set; }

    public DateOnly? DataAvanz { get; set; }

    public int? Qta { get; set; }

    public int? QtaTot { get; set; }

    public string? MyColor { get; set; }

    public DateTime? DataIns { get; set; }

    public int? IdUteIns { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class CollPlanTestum
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int? IdGender { get; set; }

    public int? IdLinea { get; set; }

    public string? Cod { get; set; }

    public string? Descr { get; set; }

    public DateOnly? DataDa { get; set; }

    public DateOnly? DataA { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

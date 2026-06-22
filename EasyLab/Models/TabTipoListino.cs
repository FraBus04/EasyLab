using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabTipoListino
{
    public int Id { get; set; }

    public string CdTipoListino { get; set; } = null!;

    public string? Descr { get; set; }

    public int? OrdPm { get; set; }

    public string? CdValuta { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public DateOnly? ValidDa { get; set; }

    public DateOnly? ValidA { get; set; }

    public bool? CkAcq { get; set; }
}

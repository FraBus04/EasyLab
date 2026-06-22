using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabCatMerceologica
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string Cod { get; set; } = null!;

    public string Descrizione { get; set; } = null!;

    public string DescEng { get; set; } = null!;

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? Tipo { get; set; }

    public int? OrdPm { get; set; }

    public int? IdCatMercMacro { get; set; }

    public int? CodCount { get; set; }

    public int? NextCount { get; set; }
}

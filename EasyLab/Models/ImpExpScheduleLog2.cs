using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpExpScheduleLog2
{
    public int K { get; set; }

    public int? Id { get; set; }

    public DateTime? DataEora { get; set; }

    public string? Sp { get; set; }

    public string? Evento { get; set; }

    public bool? Esito { get; set; }

    public DateTime? Inizio { get; set; }

    public DateTime? Fine { get; set; }

    public int? Tempo { get; set; }

    public int? NrRecord { get; set; }
}

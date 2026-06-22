using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpExpScheduleLog
{
    public int K { get; set; }

    public int? Id { get; set; }

    public DateTime? DataEora { get; set; }

    public string? Sp { get; set; }

    public string? Evento { get; set; }

    public bool? Esito { get; set; }
}

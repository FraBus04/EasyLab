using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpExpSchedule
{
    public int Id { get; set; }

    public int? Ordine { get; set; }

    public string? Attivita { get; set; }

    public string? Sp { get; set; }

    public bool? Attivo { get; set; }

    public DateTime? Dalle { get; set; }

    public DateTime? Alle { get; set; }

    public int? Passo { get; set; }

    public DateTime? NextRun { get; set; }

    public DateTime? LastRun { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SidAttivitaInOut
{
    public int Id { get; set; }

    public string? Attivita { get; set; }

    public string? Sp { get; set; }

    public DateTime? Dalle { get; set; }

    public DateTime? Alle { get; set; }

    public int? Passo { get; set; }

    public DateTime? Prossimo { get; set; }

    public DateTime? Ultimo { get; set; }

    public bool? Attivo { get; set; }

    public int? Esito { get; set; }

    public int? InErr { get; set; }
}

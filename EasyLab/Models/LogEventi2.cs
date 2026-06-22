using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class LogEventi2
{
    public int Id { get; set; }

    public DateTime? DataIns { get; set; }

    public int? IdUte { get; set; }

    public string? Sp { get; set; }

    public string? Nota { get; set; }

    public string? Esito { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class LogEventi
{
    public int Id { get; set; }

    public int? IdRif { get; set; }

    public string? Tabella { get; set; }

    public string? Operazione { get; set; }

    public int? IdUte { get; set; }

    public DateTime? DataIns { get; set; }
}

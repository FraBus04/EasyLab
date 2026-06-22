using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabAnagAgenti
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string Agente { get; set; } = null!;

    public int? IdCcli { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? Cod { get; set; }
}

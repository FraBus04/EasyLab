using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class DocTestaLink
{
    public int Id { get; set; }

    public int IdDoc { get; set; }

    public string? TipoDoc { get; set; }

    public int IdDocLink { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SidImpAnagLog
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public int? IdRif { get; set; }

    public DateTime? DataIns { get; set; }

    public string? Attr { get; set; }

    public string? Prima { get; set; }

    public string? Dopo { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabBulletPoint
{
    public int Id { get; set; }

    public string? Stato { get; set; }

    public string? Cod { get; set; }

    public string? Descr { get; set; }

    public string? Descr2 { get; set; }

    public string? Nota { get; set; }

    public int? OrdPm { get; set; }

    public byte[]? Immagine { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

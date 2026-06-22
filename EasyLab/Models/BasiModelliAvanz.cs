using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiModelliAvanz
{
    public int Id { get; set; }

    public int IdMod { get; set; }

    public int IdAvanzMod { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }

    public string? Nota { get; set; }

    public double? Time { get; set; }

    public int? IdModellista { get; set; }

    public DateTime? DataAvanz { get; set; }
}

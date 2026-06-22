using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BolDetailSt
{
    public int Id { get; set; }

    public int IdMod { get; set; }

    public string Nome { get; set; } = null!;

    public int IdFase { get; set; }

    public string? Nota { get; set; }

    public string? CdValuta { get; set; }

    public double Pz { get; set; }

    public int? IdLab { get; set; }

    public string? Um { get; set; }

    public double? Qt { get; set; }

    public int? OrdPm { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

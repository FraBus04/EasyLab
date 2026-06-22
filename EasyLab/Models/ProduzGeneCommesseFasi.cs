using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzGeneCommesseFasi
{
    public int Id { get; set; }

    public string? Stato { get; set; }

    public int? IdComm { get; set; }

    public int IdMod { get; set; }

    public string ACdAll { get; set; } = null!;

    public int? IdFase { get; set; }

    public int? IdForn { get; set; }

    public string? Um { get; set; }

    public int? Qt { get; set; }

    public int? OrdPm { get; set; }

    public double? Tempo { get; set; }

    public string? Nota { get; set; }

    public string? CdValuta { get; set; }

    public double? Prz { get; set; }

    public DateOnly? DateDaDes { get; set; }

    public DateOnly? DateAdes { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

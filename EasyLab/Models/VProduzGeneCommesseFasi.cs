using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzGeneCommesseFasi
{
    public int Id { get; set; }

    public int? IdComm { get; set; }

    public string? Tipo { get; set; }

    public int IdMod { get; set; }

    public string ACdAll { get; set; } = null!;

    public int? NrComm { get; set; }

    public string? OrdTipo { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ParteDesc { get; set; }

    public string? CommSaldo { get; set; }

    public int? CommTotCapi { get; set; }

    public int? IdFase { get; set; }

    public string? FaseCod { get; set; }

    public string? FaseDesc { get; set; }

    public int? IdForn { get; set; }

    public string? Forn { get; set; }

    public int? Qt { get; set; }

    public int? OrdPm { get; set; }

    public double? Tempo { get; set; }

    public DateOnly? DateDaDes { get; set; }

    public DateOnly? DateAdes { get; set; }
}

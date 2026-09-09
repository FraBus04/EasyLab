using System;

namespace EasyLab.Models;

public partial class ProduzGeneCommesseFasiDettaglioRiga
{
    public int Id { get; set; }

    public int? IdComm { get; set; }

    public int? IdMod { get; set; }

    public string? ACdAll { get; set; }

    public int? IdFase { get; set; }

    public int? IdForn { get; set; }

    public string? Um { get; set; }

    public double? Qt { get; set; }

    public int? OrdPm { get; set; }

    public double? Tempo { get; set; }

    public double? Prz { get; set; }

    public int? TotCar { get; set; }

    public int? TotScr { get; set; }

    public int? TotDiff { get; set; }

    public bool? CkSaldo { get; set; }

    public bool? CkInBol { get; set; }

    public bool? CkConfRientro { get; set; }

    public DateOnly? DateDaDes { get; set; }

    public DateOnly? DateADes { get; set; }

    public double? Perc { get; set; }

    public string? Tipo { get; set; }

    public string? FaseCod { get; set; }

    public string? FaseDesc { get; set; }

    public string? Lab { get; set; }

    public int? Gg { get; set; }

    public string? FaseCol { get; set; }

    public bool? CkFaseCar { get; set; }

    public DateOnly? DataCarMin { get; set; }

    public DateOnly? DataScrMax { get; set; }
}

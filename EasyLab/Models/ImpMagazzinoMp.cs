using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpMagazzinoMp
{
    public string? Tipo { get; set; }

    public string? Deposito { get; set; }

    public string? Barcode { get; set; }

    public string? CodiceArticolo { get; set; }

    public string? Variante { get; set; }

    public string? Lotto { get; set; }

    public double? Qta { get; set; }

    public int Id { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public bool? CkMatMis { get; set; }

    public string? Mat { get; set; }

    public string? MatCol { get; set; }

    public string? MatMis { get; set; }

    public bool? CkErr { get; set; }

    public string? Codice { get; set; }

    public string? CodiceCliente { get; set; }

    public string? Descrizione { get; set; }

    public string? DescSupp { get; set; }

    public string? Um { get; set; }

    public string? Giacenza { get; set; }

    public int? IdCcli { get; set; }

    public int? IdCcliDest { get; set; }

    public double? QtDichiarata { get; set; }

    public double? QtRiscontrata { get; set; }

    public int? Hutile { get; set; }

    public double? Difet1 { get; set; }

    public double? Difet2 { get; set; }

    public double? Difet3 { get; set; }

    public double? Difet4 { get; set; }

    public int? PesoMtqreale { get; set; }

    public int? PesoMtlreale { get; set; }
}

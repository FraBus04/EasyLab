using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MovimentiMpBonadiman
{
    public string? CausaleOrdine { get; set; }

    public string? Descrizione { get; set; }

    public string? Codice { get; set; }

    public string? Intestatario { get; set; }

    public string? NOrdine { get; set; }

    public string? DataOrdine { get; set; }

    public string? RifCli { get; set; }

    public string? DataRifCli { get; set; }

    public string? Fase { get; set; }

    public string? Descrizione2 { get; set; }

    public string? Stagionalità { get; set; }

    public string? Descrizione3 { get; set; }

    public string? Utente { get; set; }

    public string? NRiga { get; set; }

    public string? Articolo { get; set; }

    public string? CodiceCliente { get; set; }

    public string? Descrizione4 { get; set; }

    public string? DescSupp { get; set; }

    public string? Um { get; set; }

    public decimal? QtaTotaleOrdine { get; set; }

    public decimal? QtaResidua { get; set; }

    public decimal? PrezzoUnit { get; set; }

    public string? DataConsegnaPrevista { get; set; }

    public string? CausaleDdtFt { get; set; }

    public string? Descrizione5 { get; set; }

    public string? NumDocDdtFt { get; set; }

    public string? DataRegDdtFt { get; set; }

    public string? UmDdtFt { get; set; }

    public decimal? QtaTotaleDdtFt { get; set; }

    public int Id { get; set; }

    public string? Mat { get; set; }

    public string? MatCol { get; set; }

    public string? MatMis { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public bool? CkMatMis { get; set; }

    public bool? CkErr { get; set; }

    public DateTime? DataImp { get; set; }
}

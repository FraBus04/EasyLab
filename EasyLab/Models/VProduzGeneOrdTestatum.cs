using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzGeneOrdTestatum
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdContatto { get; set; }

    public int OrdNr { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public int IdStag { get; set; }

    public string? Stag { get; set; }

    public string OrdTipo { get; set; } = null!;

    public string? OrdTipoDesc { get; set; }

    public DateTime? OrdData { get; set; }

    public int Ccli { get; set; }

    public string? Anag1 { get; set; }

    public string? Anag2 { get; set; }

    public string? Via { get; set; }

    public string? Cap { get; set; }

    public string? Citta { get; set; }

    public int? CcliDest { get; set; }

    public string? Anag1Desc { get; set; }

    public string? Anag2Desc { get; set; }

    public string? ViaDesc { get; set; }

    public string? CapDesc { get; set; }

    public string? CittaDesc { get; set; }

    public DateTime? DataCons { get; set; }

    public string? DataPrevCons { get; set; }

    public double? Sco1 { get; set; }

    public DateTime? DataConsDa { get; set; }

    public DateTime? DataConsA { get; set; }

    public string? Po { get; set; }

    public string? Nazione { get; set; }

    public string? NazioneDest { get; set; }

    public string? StrNota { get; set; }

    public int? IdAg { get; set; }

    public string? CdValuta { get; set; }

    public int? IdTipoList { get; set; }

    public int? IdPag { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public int? IdDdtResa { get; set; }

    public int? IdDdtAspetto { get; set; }

    public int? IdDdtCausale { get; set; }

    public double? Provv { get; set; }

    public double? CostiTrasp { get; set; }

    public double? CostiAltri { get; set; }

    public int? IdCodIva { get; set; }
}

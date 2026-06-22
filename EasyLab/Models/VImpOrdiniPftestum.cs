using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VImpOrdiniPftestum
{
    public int Id { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? Stato { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public long? IdErpOrd { get; set; }

    public string? OrdTipo { get; set; }

    public int? OrdNr { get; set; }

    public DateOnly? OrdData { get; set; }

    public int? Ccli { get; set; }

    public string? Anag1 { get; set; }

    public string? Anag2 { get; set; }

    public string? Via { get; set; }

    public string? CapNew { get; set; }

    public string? Citta { get; set; }

    public string? Prov { get; set; }

    public string? Nazione { get; set; }

    public int? CcliDest { get; set; }

    public string? Anag1Dest { get; set; }

    public string? Anag2Dest { get; set; }

    public string? ViaDest { get; set; }

    public string? CapNewDest { get; set; }

    public string? CittaDest { get; set; }

    public string? ProvDest { get; set; }

    public string? NazioneDest { get; set; }

    public int? IdAg { get; set; }

    public string? Ag { get; set; }

    public DateOnly? DataConsDa { get; set; }

    public DateOnly? DataConsA { get; set; }

    public string? Po { get; set; }

    public int? IdTipoList { get; set; }

    public string? CdTipoListino { get; set; }

    public string? TipoListinoDesc { get; set; }

    public int? IdPag { get; set; }

    public string? PagCod { get; set; }

    public string? PagDesc { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public string? TraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public string? Vettore { get; set; }

    public int? IdDdtResa { get; set; }

    public string? Resa { get; set; }

    public double? CostiTrasp { get; set; }

    public double? CostiAltri { get; set; }

    public int? IdCodIva { get; set; }

    public DateOnly? DataCons { get; set; }

    public string StatoImp { get; set; } = null!;

    public string? CdValuta { get; set; }

    public int? TotCapi { get; set; }

    public double? TotVal { get; set; }

    public bool? CkErr { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

/// <summary>
/// 
/// READYIMP
/// ERR
/// IMPORTED
/// 
/// </summary>
public partial class ImpOrdiniPftestum
{
    public int Id { get; set; }

    public long? IdErpOrd { get; set; }

    public string? Stato { get; set; }

    public int? IdStag { get; set; }

    public int? IdContatto { get; set; }

    public string? OrdTipo { get; set; }

    public int? OrdNr { get; set; }

    public DateOnly? OrdData { get; set; }

    public string? Po { get; set; }

    public int? Ccli { get; set; }

    public int? CcliDest { get; set; }

    public DateOnly? DataCons { get; set; }

    public DateOnly? DataConsDa { get; set; }

    public DateOnly? DataConsA { get; set; }

    public double? Sco1 { get; set; }

    public int? IdAg { get; set; }

    public int? IdTipoList { get; set; }

    public int? IdPag { get; set; }

    public int? IdCodIva { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public int? IdDdtResa { get; set; }

    public int? IdRagg1 { get; set; }

    public int? IdRagg2 { get; set; }

    public int? IdRagg3 { get; set; }

    public int? IdRagg4 { get; set; }

    public int? IdRagg5 { get; set; }

    public int? IdDdtAspetto { get; set; }

    public int? IdDdtCausale { get; set; }

    public string? CdValuta { get; set; }

    public double? Provv { get; set; }

    public double? CostiTrasp { get; set; }

    public double? CostiAltri { get; set; }

    public string StatoImp { get; set; } = null!;

    public string? Nota { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public DateTime? DataImp { get; set; }

    public DateTime? DataExp { get; set; }

    public bool? CkErr { get; set; }

    public string? CdMag { get; set; }

    public int? TotalUnits { get; set; }

    public double? OrderTotal { get; set; }

    public int? TotCapi { get; set; }

    public double? TotVal { get; set; }

    public int? IdLineSheet { get; set; }

    public int? IdLinea { get; set; }
}

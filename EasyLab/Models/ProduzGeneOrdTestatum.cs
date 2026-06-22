using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzGeneOrdTestatum
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public string Stato { get; set; } = null!;

    public int IdStag { get; set; }

    public int IdContatto { get; set; }

    public string OrdTipo { get; set; } = null!;

    public int OrdNr { get; set; }

    public DateTime? OrdData { get; set; }

    public int Ccli { get; set; }

    public int? CcliDest { get; set; }

    public string? RifIdContatto { get; set; }

    public DateTime? DataCons { get; set; }

    public string? StrVettore { get; set; }

    public string? StrPorto { get; set; }

    public string? StrPagamento { get; set; }

    public string? StrNota { get; set; }

    public string? DataPrevCons { get; set; }

    public double? Sco1 { get; set; }

    public int? IdAg { get; set; }

    public DateTime? DataConsDa { get; set; }

    public DateTime? DataConsA { get; set; }

    public string? Po { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? CdValuta { get; set; }

    public int? IdTipoList { get; set; }

    public int? IdPag { get; set; }

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

    public DateTime? DataImp { get; set; }

    public DateTime? DataExp { get; set; }

    public string? StatoExp { get; set; }

    public long? IdErp { get; set; }

    public double? Provv { get; set; }

    public double? CostiTrasp { get; set; }

    public double? CostiAltri { get; set; }

    public int? IdCodIva { get; set; }

    public long? IdErpDoc { get; set; }

    public string? StatoOrd { get; set; }

    public string? CdMag { get; set; }

    public int? IdLineSheet { get; set; }

    public int? IdLinea { get; set; }

    public int? IdVotoOrd { get; set; }
}

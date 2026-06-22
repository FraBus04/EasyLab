using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VOrdiniCltestum
{
    public int Id { get; set; }

    public int IdStag { get; set; }

    public int IdContatto { get; set; }

    public string OrdTipo { get; set; } = null!;

    public string? OrdTipoDesc { get; set; }

    public int OrdNr { get; set; }

    public int Ccli { get; set; }

    public string? Anag1 { get; set; }

    public string? Citta { get; set; }

    public string? RifIdContatto { get; set; }

    public string? StrPagamento { get; set; }

    public string? StrPorto { get; set; }

    public string? StrVettore { get; set; }

    public int? CcliDest { get; set; }

    public string? Anag2 { get; set; }

    public string? Via { get; set; }

    public string? Cap { get; set; }

    public string? Prov { get; set; }

    public string? Tel { get; set; }

    public string? Fax { get; set; }

    public string? Chiedere { get; set; }

    public string? Email { get; set; }

    public string? Piva { get; set; }

    public string? CodFisc { get; set; }

    public string? Nazione { get; set; }

    public string? CdCcliErp1 { get; set; }

    public string? DestAnag1 { get; set; }

    public string? DestAnag2 { get; set; }

    public string? DestVia { get; set; }

    public string? DestCap { get; set; }

    public string? DestCitta { get; set; }

    public string? DestProv { get; set; }

    public string? DestChiedere { get; set; }

    public string? DestNazione { get; set; }

    public DateTime? OrdData { get; set; }

    public string? StrNotaTestata { get; set; }

    public string StatoOrd { get; set; } = null!;

    public string? Stag { get; set; }

    public string? Contatto { get; set; }

    public string? DataPrevCons { get; set; }

    public int? TotCapi { get; set; }

    public int? TotTag { get; set; }

    public int? TotMag { get; set; }

    public int? TotSped { get; set; }

    public int? TotAnn { get; set; }

    public string? CdValuta { get; set; }

    public double? TotVal { get; set; }

    public double? TotValMag { get; set; }

    public double? TotValSped { get; set; }

    public int? IdAg { get; set; }

    public string? Agente { get; set; }

    public DateTime? DataConsDa { get; set; }

    public DateTime? DataConsA { get; set; }

    public string? Po { get; set; }

    public DateTime? DataCons { get; set; }

    public string? CanaleVendita { get; set; }

    public int? IdTipoList { get; set; }

    public string? TipoListCod { get; set; }

    public string? TipoListDescr { get; set; }

    public string? CdCcliErp2 { get; set; }

    public string? PagCod { get; set; }

    public string? PagDesc { get; set; }

    public string? TraspCura { get; set; }

    public string? Vettore { get; set; }

    public string? Resa { get; set; }

    public string? Ragg1 { get; set; }

    public string? Ragg2 { get; set; }

    public string? Ragg3 { get; set; }

    public string? Ragg4 { get; set; }

    public string? Ragg5 { get; set; }

    public DateTime? DataImp { get; set; }

    public DateTime? DataExp { get; set; }

    public string? StatoExp { get; set; }

    public double? Provv { get; set; }

    public double? CostiTrasp { get; set; }

    public double? CostiAltri { get; set; }

    public double? Sco1 { get; set; }

    public int? IdCodIva { get; set; }

    public string? CodIva { get; set; }

    public string? CodIvadesc { get; set; }

    public string? Causale { get; set; }

    public string? MagCarico { get; set; }

    public int? IdRagg1 { get; set; }

    public int? IdRagg2 { get; set; }

    public int? IdRagg3 { get; set; }

    public int? IdRagg4 { get; set; }

    public int? IdRagg5 { get; set; }

    public string? CdMag { get; set; }

    public string? Ragg3Cod { get; set; }

    public string? LineSheetCod { get; set; }

    public string? LineSheetDesc { get; set; }

    public int? IdLineSheet { get; set; }
}

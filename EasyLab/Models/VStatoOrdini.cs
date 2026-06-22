using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VStatoOrdini
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public string OrdTipo { get; set; } = null!;

    public int IdOrd { get; set; }

    public int OrdNr { get; set; }

    public int? Ccli { get; set; }

    public string? Anag1 { get; set; }

    public string? Anag2 { get; set; }

    public string? Via { get; set; }

    public string? CapNew { get; set; }

    public string? Citta { get; set; }

    public string? Prov { get; set; }

    public string? Tel { get; set; }

    public string? Fax { get; set; }

    public int? IdAg { get; set; }

    public string? Agente { get; set; }

    public DateTime? OrdData { get; set; }

    public DateTime? DataCons { get; set; }

    public string? StrNota { get; set; }

    public string? DataPrevCons { get; set; }

    public double? Sco1 { get; set; }

    public int? CcliDest { get; set; }

    public string? Anag1Dest { get; set; }

    public string? Anag2Dest { get; set; }

    public string? ViaDest { get; set; }

    public string? CittaDest { get; set; }

    public string? ProvDest { get; set; }

    public string? CapNewDest { get; set; }

    public string? CdValuta { get; set; }

    public int? TotCapi { get; set; }

    public int? TotCapi5 { get; set; }

    public int? TotCapi6 { get; set; }

    public int? TotCapi7 { get; set; }

    public double? TotVal { get; set; }

    public double? TotVal5 { get; set; }

    public double? TotVal6 { get; set; }

    public double? TotVal7 { get; set; }

    public double? PercCapi1 { get; set; }

    public double? PercCapi2 { get; set; }

    public double? PercCapi3 { get; set; }

    public double? PercCapi4 { get; set; }

    public double? PercCapi5 { get; set; }

    public double? PercCapi6 { get; set; }

    public double? PercCapi7 { get; set; }

    public string? Stato { get; set; }

    public int? DiffCapi1 { get; set; }

    public int? DiffCapi4 { get; set; }

    public int? DiffCapi5 { get; set; }

    public int? DiffCapi6 { get; set; }

    public int? DiffCapi7 { get; set; }

    public string? AreaCod { get; set; }

    public string? NazioneCod { get; set; }

    public string? Nazionedesc { get; set; }

    public int? TotCapi1 { get; set; }

    public int? TotCapi2 { get; set; }

    public int? TotCapi3 { get; set; }

    public int? TotCapi4 { get; set; }

    public double? TotVal1 { get; set; }

    public double? TotVal2 { get; set; }

    public double? TotVal3 { get; set; }

    public double? TotVal4 { get; set; }

    public double? PercVal1 { get; set; }

    public double? PercVal2 { get; set; }

    public double? PercVal3 { get; set; }

    public double? PercVal4 { get; set; }

    public double? PercVal5 { get; set; }

    public double? PercVal6 { get; set; }

    public double? PercVal7 { get; set; }

    public int? DiffCapi2 { get; set; }

    public int? DiffCapi3 { get; set; }

    public int? TotCapiA { get; set; }

    public string? RifIdContatto { get; set; }

    public string? Po { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public double? DiffVal1 { get; set; }

    public double? DiffVal2 { get; set; }

    public double? DiffVal3 { get; set; }

    public double? DiffVal4 { get; set; }

    public double? DiffVal5 { get; set; }

    public double? DiffVal6 { get; set; }

    public double? DiffVal7 { get; set; }

    public double? TotValA { get; set; }

    public string? AreaDesc { get; set; }

    public string? CanaleVendita { get; set; }

    public int? TotCapi0 { get; set; }

    public double? TotVal0 { get; set; }

    public double? PercCapi0 { get; set; }

    public double? PercVal0 { get; set; }

    public int? DiffCapi0 { get; set; }

    public double? DiffVal0 { get; set; }

    public int? IdUte { get; set; }

    public string? Stag { get; set; }

    public double? TotValValuta { get; set; }

    public DateTime? DataConsDa { get; set; }

    public DateTime? DataConsA { get; set; }

    public int? IdRagg1 { get; set; }

    public string? Ragg1Cod { get; set; }

    public string? Ragg1Desc { get; set; }

    public int? IdRagg2 { get; set; }

    public string? Ragg2Cod { get; set; }

    public string? Ragg2Desc { get; set; }

    public int? IdRagg3 { get; set; }

    public string? Ragg3Cod { get; set; }

    public string? Ragg3Desc { get; set; }

    public string? StatoOrd { get; set; }

    public string? TipiOrdStr { get; set; }

    public double? TotSk { get; set; }

    public double? TotSk5 { get; set; }

    public double? TotSk6 { get; set; }

    public double? TotSk7 { get; set; }

    public bool? CkSk { get; set; }

    public double? TotSkfasi { get; set; }

    public double? TotSkbom { get; set; }

    public double? TotSkaltri { get; set; }

    public int? AnnCapi01 { get; set; }

    public int? AnnCapi01P { get; set; }

    public int? AnnCapi01C { get; set; }

    public int? AnnCapi01S { get; set; }

    public int? AnnCapi01A { get; set; }

    public int? AnnCapi02 { get; set; }

    public int? AnnCapi02P { get; set; }

    public int? AnnCapi02C { get; set; }

    public int? AnnCapi02S { get; set; }

    public int? AnnCapi02A { get; set; }

    public int? AnnVal01 { get; set; }

    public int? AnnVal01P { get; set; }

    public int? AnnVal01C { get; set; }

    public int? AnnVal01S { get; set; }

    public int? AnnVal01A { get; set; }

    public int? AnnVal02 { get; set; }

    public int? AnnVal02P { get; set; }

    public int? AnnVal02C { get; set; }

    public int? AnnVal02S { get; set; }

    public int? AnnVal02A { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataExp { get; set; }

    public double? TotValNetto { get; set; }

    public int? TotCapiNetto { get; set; }

    public string? TipoOrdineClstr { get; set; }

    public string? CanaleVenditaStr { get; set; }

    public string? StagDesc { get; set; }
}

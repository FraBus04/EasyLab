using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VElencoOrdini2
{
    public string StatoRigaOrd { get; set; } = null!;

    public int IdStag { get; set; }

    public int IdContatto { get; set; }

    public string OrdTipo { get; set; } = null!;

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

    public string? Expr1 { get; set; }

    public string? DestAnag1 { get; set; }

    public string? DestAnag2 { get; set; }

    public string? DestVia { get; set; }

    public string? DestCap { get; set; }

    public string? DestCitta { get; set; }

    public string? DestProv { get; set; }

    public string? DestChiedere { get; set; }

    public string? DestNazione { get; set; }

    public int IdOrd { get; set; }

    public DateTime? OrdData { get; set; }

    public string? StrNotaTestata { get; set; }

    public string Stato { get; set; } = null!;

    public string? Stag { get; set; }

    public string? Contatto { get; set; }

    public string? DataPrevCons { get; set; }

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

    public int TotCapi { get; set; }

    public int TotNetto { get; set; }

    public int TotDaLav { get; set; }

    public int TotInLav { get; set; }

    public int TotDaRec { get; set; }

    public int TotAmag { get; set; }

    public int TotSped { get; set; }

    public int TotAnn { get; set; }

    public string? CdValuta { get; set; }

    public double TotVal { get; set; }

    public double TotNettoVal { get; set; }

    public double TotDaLavVal { get; set; }

    public double TotInLavVal { get; set; }

    public double TotDaRecVal { get; set; }

    public double TotAmagVal { get; set; }

    public double TotSpedVal { get; set; }

    public double TotAnnVal { get; set; }

    public DateTime? DataImp { get; set; }

    public DateTime? DataExp { get; set; }

    public string? StatoExp { get; set; }

    public int? IdPag { get; set; }

    public string? PagDesc { get; set; }

    public string? StatoOrd { get; set; }

    public string? VotoCod { get; set; }

    public int? IdVoto { get; set; }

    public string? Ragg1 { get; set; }

    public string? Ragg2 { get; set; }

    public string? Ragg3 { get; set; }

    public string? Ragg4 { get; set; }

    public string? Ragg5 { get; set; }

    public string? CdMag { get; set; }

    public string? LineSheetCod { get; set; }

    public string? LineSheetDesc { get; set; }
}

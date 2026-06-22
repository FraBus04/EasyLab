using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VElencoOrdini
{
    public int IdOrd { get; set; }

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

    public int? CcliDest { get; set; }

    public string? StatoOrd2 { get; set; }
}

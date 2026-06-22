using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VOrdiniMpTestum
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public string Stato { get; set; } = null!;

    public string? StatoOrdDesc { get; set; }

    public string TipoOrd { get; set; } = null!;

    public string? TipoOrdDesc { get; set; }

    public int IdCcli { get; set; }

    public string NrOrd { get; set; } = null!;

    public string CdValuta { get; set; } = null!;

    public int? IdPag { get; set; }

    public DateOnly DataOrd { get; set; }

    public DateOnly? DataConfFor { get; set; }

    public DateOnly? DataConsConf { get; set; }

    public string? Nota { get; set; }

    public string? FlagApp { get; set; }

    public DateOnly? DataApp { get; set; }

    public string? Anag1 { get; set; }

    public string? Anag2 { get; set; }

    public string? Via { get; set; }

    public string? CapNew { get; set; }

    public string? Citta { get; set; }

    public string? Prov { get; set; }

    public string? Tel { get; set; }

    public string? Fax { get; set; }

    public string? Chiedere { get; set; }

    public string? Email { get; set; }

    public string? Piva { get; set; }

    public string? CodFisc { get; set; }

    public string? Nazione { get; set; }

    public string CdStatoOrdMp { get; set; } = null!;

    public string? StatoOrdMp { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public string? StagDesc { get; set; }

    public int? IdLinea { get; set; }

    public string? Linea { get; set; }

    public string? Po { get; set; }

    public double? ValQtOrd { get; set; }

    public double? ValQtArr { get; set; }

    public double? PercArr { get; set; }

    public DateOnly DataPrev { get; set; }

    public int? IdDdtVettore { get; set; }

    public string? Vettore { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public string? TraspCura { get; set; }

    public int? IdCcliDest { get; set; }

    public string? Anag1Dest { get; set; }

    public string? Anag2Dest { get; set; }

    public string? ViaDest { get; set; }

    public string? CapDest { get; set; }

    public string? CittaDest { get; set; }

    public string? ProvDest { get; set; }

    public string? NazioneDest { get; set; }

    public string? PagCod { get; set; }

    public string? PagDesc { get; set; }

    public int? IdResa { get; set; }

    public string? ResaCod { get; set; }

    public string? ResaDesc { get; set; }

    public string? StatoApp { get; set; }

    public string? StatoAppDescr { get; set; }

    public int? IdUteApp { get; set; }

    public string? UteApp { get; set; }

    public DateTime? DateApp { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? NrAllegati { get; set; }

    public DateTime? DataExp { get; set; }

    public string StatoExp { get; set; } = null!;

    public string? CdMag { get; set; }
}

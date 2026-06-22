using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class DocTestum
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdClasseDoc { get; set; }

    public int IdTipoDoc { get; set; }

    /// <summary>
    /// OPEN
    /// CLOSED
    /// </summary>
    public string StatoDoc { get; set; } = null!;

    public int IdContatto { get; set; }

    public int? IdStag { get; set; }

    public int? IdCcli { get; set; }

    public int? IdCcliDest { get; set; }

    public string? NrDoc { get; set; }

    public DateOnly? DataDoc { get; set; }

    public DateOnly DataMov { get; set; }

    public int IdCausale1 { get; set; }

    public int? IdCausale2 { get; set; }

    public int? IdTipoMov1 { get; set; }

    public int? IdTipoMov2 { get; set; }

    public string? CdMag1 { get; set; }

    public string? CdMag2 { get; set; }

    public bool Aperto { get; set; }

    public int TotCapi { get; set; }

    public string? Nota { get; set; }

    public int? IdDdtCausale { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public int? IdDdtAspetto { get; set; }

    public int? IdDdtResa { get; set; }

    public int? IdPag { get; set; }

    public int? IdAg { get; set; }

    public int? IdTipoList { get; set; }

    public int? NrColli { get; set; }

    public decimal? KgTot { get; set; }

    public decimal? KgTotNetto { get; set; }

    public string? CdValuta { get; set; }

    public double? Sco1 { get; set; }

    public double? Sco2 { get; set; }

    public double? Sco3 { get; set; }

    public int? TotVal { get; set; }

    public int? IdOrd { get; set; }

    public int? IdRagg1 { get; set; }

    public int? IdRagg2 { get; set; }

    public int? IdRagg3 { get; set; }

    public int? IdRagg4 { get; set; }

    public int? IdRagg5 { get; set; }

    public int? IdTestaOld { get; set; }

    public int? IdLista { get; set; }

    public int? IdComm { get; set; }

    public int? CkMov1 { get; set; }

    public bool? CkMov2 { get; set; }

    public string? CodMagBp { get; set; }

    public int? IdPriorita { get; set; }

    public string? TipoNum { get; set; }

    public bool? FlagGiaExp { get; set; }

    public DateTime? DataExp { get; set; }

    public string? StatoExp { get; set; }

    public int? IdTipoAnagStake { get; set; }

    public bool? CkMovFasi1 { get; set; }

    public bool? CkMovFasi2 { get; set; }

    public bool? CkAvanzOrdine { get; set; }

    public bool? CkOrdMp { get; set; }

    public bool? CkBp { get; set; }

    public bool? CkCdc { get; set; }

    public bool? CkComm { get; set; }

    public bool? CkNum { get; set; }

    public bool CkImpegna { get; set; }

    public int? IdExpTesta { get; set; }

    public int? IdCodIva { get; set; }

    public long? IdImport { get; set; }

    public decimal? Cambio { get; set; }

    public int? IdPkltesta { get; set; }

    public int? IdFase1 { get; set; }

    public int? IdFase2 { get; set; }

    public DateTime? DataInitTrasp { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

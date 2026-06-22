using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VDocTestum
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdContatto { get; set; }

    public int IdTipoDoc { get; set; }

    public string? TipoDoc { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public string? Contatto { get; set; }

    public int IdCausale1 { get; set; }

    public int? IdCausale2 { get; set; }

    public int? IdTipoMov1 { get; set; }

    public int? IdTipoMov2 { get; set; }

    public string? Mov1 { get; set; }

    public string? Mov2 { get; set; }

    public string? CdMag1 { get; set; }

    public string? CdMag2 { get; set; }

    public string? NrDoc { get; set; }

    public DateOnly? DataDoc { get; set; }

    public int? IdCcli { get; set; }

    public bool Aperto { get; set; }

    public int TotCapi { get; set; }

    public string? Anag1 { get; set; }

    public string? Anag2 { get; set; }

    public string? Via { get; set; }

    public string? Cap { get; set; }

    public string? Citta { get; set; }

    public string? Prov { get; set; }

    public string? Nazione { get; set; }

    public string? Nota { get; set; }

    public int? IdDdtCausale { get; set; }

    public string? Causale { get; set; }

    public int? IdDdtResa { get; set; }

    public string? Resa { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public string? TraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public string? Vettore { get; set; }

    public string? VettoreCod { get; set; }

    public int? IdDdtAspetto { get; set; }

    public string? Aspetto { get; set; }

    public int? IdCcliDest { get; set; }

    public string? DestAnag1 { get; set; }

    public string? DestAnag2 { get; set; }

    public string? DestVia { get; set; }

    public string? DestCap { get; set; }

    public string? DestCitta { get; set; }

    public string? DestProv { get; set; }

    public string? DestNazione { get; set; }

    public int? NrColli { get; set; }

    public decimal? KgTot { get; set; }

    public int? TotVal { get; set; }

    public string? CdValuta { get; set; }

    public int? IdOrd { get; set; }

    public bool? FlagGiaExp { get; set; }

    public DateTime? DataExp { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string StatoDoc { get; set; } = null!;

    public int IdClasseDoc { get; set; }

    public DateOnly DataMov { get; set; }

    public double? Sco1 { get; set; }

    public int? CkMov1 { get; set; }

    public bool? CkMov2 { get; set; }

    public string? StatoExp { get; set; }

    public int? IdLista { get; set; }

    public int? IdComm { get; set; }

    public string? OrdTipo { get; set; }

    public int? OrdNr { get; set; }

    public string? TipoDocDesc { get; set; }

    public bool? CkNum { get; set; }

    public long? IdErpDocOrd { get; set; }

    public string? CodMagBp { get; set; }

    public int? IdPriorita { get; set; }

    public string? TipoNum { get; set; }

    public int? IdPag { get; set; }

    public string? PagCod { get; set; }

    public string? PagDesc { get; set; }

    public string? TipoDocComportForm { get; set; }

    public bool? CkBp { get; set; }

    public bool? CkCdc { get; set; }

    public bool? CkComm { get; set; }

    public bool? Expr1 { get; set; }

    public bool? CkOrdMp { get; set; }

    public bool? CkMovFasi1 { get; set; }

    public bool? CkMovFasi2 { get; set; }

    public bool? CkAvanzOrdine { get; set; }

    public string? PoOrd { get; set; }

    public string? CdReport { get; set; }

    public string? RifIdContatto { get; set; }

    public int? IdTipoList { get; set; }

    public string? TipoListCod { get; set; }

    public string? TipoListDesc { get; set; }

    public int? IdExpTesta { get; set; }

    public decimal? Cambio { get; set; }

    public int? IdPkltesta { get; set; }

    public int? IdFase1 { get; set; }

    public string? Fase1Cod { get; set; }

    public string? Fase1Desc { get; set; }

    public int? IdFase2 { get; set; }

    public string? Fase2Cod { get; set; }

    public string? Fase2Desc { get; set; }

    public decimal? KgTotNetto { get; set; }

    public DateTime? DataInitTrasp { get; set; }

    public string? ContattoTel { get; set; }

    public string? ContattoEmail { get; set; }

    public string? ContattoVia { get; set; }

    public string? ContattoCap { get; set; }

    public string? ContattoCitta { get; set; }

    public string? ContattoProv { get; set; }

    public byte[]? ContattoImg { get; set; }

    public bool CkImpegna { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VDocMp
{
    public int Id { get; set; }

    public string? Stato { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public int? IdDoc { get; set; }

    public int? IdTipoDoc { get; set; }

    public string? TipoDoc { get; set; }

    public string? TipoDocDesc { get; set; }

    public int? IdTipoDati { get; set; }

    public string? CdMag1 { get; set; }

    public string? CdMag2 { get; set; }

    public string? NrDoc { get; set; }

    public DateOnly? DataDoc { get; set; }

    public DateOnly? DataMov { get; set; }

    public int? IdCcli { get; set; }

    public string? Anag1 { get; set; }

    public string? Anag2 { get; set; }

    public string? Via { get; set; }

    public string? Cap { get; set; }

    public string? Citta { get; set; }

    public string? Prov { get; set; }

    public string? Piva { get; set; }

    public string? CodFisc { get; set; }

    public string? Nazione { get; set; }

    public int? IdCcliDest { get; set; }

    public string? Anag1Dest { get; set; }

    public string? Anag2Dest { get; set; }

    public string? ViaDest { get; set; }

    public string? CapDest { get; set; }

    public string? CittaDest { get; set; }

    public string? ProvDest { get; set; }

    public string? NazioneDest { get; set; }

    public bool? Aperto { get; set; }

    public int? IdStagTesta { get; set; }

    public string? StagTesta { get; set; }

    public int? IdCausale1 { get; set; }

    public int? IdCausale2 { get; set; }

    public int? IdTipoMov1 { get; set; }

    public string? Mov1Cod { get; set; }

    public string? Mov1Desc { get; set; }

    public int? IdTipoMov2 { get; set; }

    public string? Mov2Cod { get; set; }

    public string? Mov2Desc { get; set; }

    public string? CdValuta { get; set; }

    public decimal? PzArt { get; set; }

    public int? ValTotDoc { get; set; }

    public decimal? ValTotRiga { get; set; }

    public double? Sco1Testa { get; set; }

    public double? Sco2Testa { get; set; }

    public double? Sco3Testa { get; set; }

    public double? Sco1 { get; set; }

    public double? Sco2 { get; set; }

    public double? Sco3 { get; set; }

    public decimal? KgTot { get; set; }

    public int? NrColli { get; set; }

    public int? IdDdtCausale { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public int? IdDdtAspetto { get; set; }

    public int? IdDdtResa { get; set; }

    public int? IdPag { get; set; }

    public bool? FlagGiaExp { get; set; }

    public DateTime? DataExp { get; set; }

    public string? Nota { get; set; }

    public int? CkControllo { get; set; }

    public int? IdBox { get; set; }

    public string? Causale { get; set; }

    public string? TraspCura { get; set; }

    public string? Vettore { get; set; }

    public string? ResaCod { get; set; }

    public int? IdOrd { get; set; }

    public string? OrdTipo { get; set; }

    public int? OrdNr { get; set; }

    public DateTime? OrdData { get; set; }

    public string? StatoExp { get; set; }

    public string? Aspetto { get; set; }

    public int? IdPriorita { get; set; }

    public string? CodMagBp { get; set; }

    public int? IdFase1 { get; set; }

    public string? FaseCod1 { get; set; }

    public string? FaseDesc1 { get; set; }

    public int? IdFase2 { get; set; }

    public string? FaseCod2 { get; set; }

    public string? FaseDesc2 { get; set; }

    public int? IdComm { get; set; }

    public DateOnly? DataRicRientro { get; set; }

    public DateOnly? DataConfRientro { get; set; }

    public bool? CkConfRientro { get; set; }

    public int IdClasseDoc { get; set; }

    public string? StatoDoc { get; set; }

    public int? NrComm { get; set; }

    public string? NotaTesta { get; set; }

    public string? TipoNum { get; set; }

    public string? Mat { get; set; }

    public string? DescMat { get; set; }

    public string? MatCol { get; set; }

    public string MatColDesc { get; set; } = null!;

    public string MatMis { get; set; } = null!;

    public string MatMisDesc { get; set; } = null!;

    public string NrPezza { get; set; } = null!;

    public string Lotto { get; set; } = null!;

    public decimal? Qta { get; set; }

    public int IdStag { get; set; }

    public string? CommContatto { get; set; }

    public string? CommOrdTipo { get; set; }

    public string? CommStag { get; set; }

    public string? CommMod { get; set; }

    public string? CommTess { get; set; }

    public string? CommNome { get; set; }

    public int? CommTotCapi { get; set; }

    public bool? CkStampa { get; set; }

    public int? IdContattoMat { get; set; }

    public string? ContattoMat { get; set; }

    public string? MatColMis { get; set; }

    public string? MatColMisDesc { get; set; }

    public string? Um { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public string? IdEanstr { get; set; }

    public DateTime? DataInitTrasp { get; set; }

    public decimal? KgTotNetto { get; set; }

    public string? ModRagg1Desc { get; set; }

    public string? VociDoganali { get; set; }

    public string? Composizione { get; set; }

    public string? MadeIn { get; set; }
}

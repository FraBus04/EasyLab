using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VDocClv
{
    public int Id { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public int? IdDoc { get; set; }

    public int? IdTipoDoc { get; set; }

    public string? TipoDoc { get; set; }

    public string? TipoDocDesc { get; set; }

    public int? IdTipoDati { get; set; }

    public string? Stato { get; set; }

    public int? TotCapi { get; set; }

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

    public string? Prov { get; set; }

    public string? Citta { get; set; }

    public string? Nazione { get; set; }

    public string? Piva { get; set; }

    public string? CodFisc { get; set; }

    public int? IdCcliDest { get; set; }

    public string? Anag1Dest { get; set; }

    public string? Anag2Dest { get; set; }

    public string? ViaDest { get; set; }

    public string? CapDest { get; set; }

    public string? ProvDest { get; set; }

    public string? CittaDest { get; set; }

    public string? NazioneDest { get; set; }

    public bool? Aperto { get; set; }

    public int? TotCapiTesta { get; set; }

    public int IdStag { get; set; }

    public string? Stag { get; set; }

    public int? IdStagTesta { get; set; }

    public string? StagTesta { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ParteDesc { get; set; }

    public string? ParteCol { get; set; }

    public string? ParteColDesc { get; set; }

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

    public int? IdSet { get; set; }

    public string? IdSetDesc { get; set; }

    public string? Tg1 { get; set; }

    public string? Tg2 { get; set; }

    public string? Tg3 { get; set; }

    public string? Tg4 { get; set; }

    public string? Tg5 { get; set; }

    public string? Tg6 { get; set; }

    public string? Tg7 { get; set; }

    public string? Tg8 { get; set; }

    public string? Tg9 { get; set; }

    public string? Tg10 { get; set; }

    public string? Tg11 { get; set; }

    public string? Tg12 { get; set; }

    public string? Tg13 { get; set; }

    public string? Tg14 { get; set; }

    public string? Tg15 { get; set; }

    public string? Tg16 { get; set; }

    public decimal? KgTot { get; set; }

    public int? NrColli { get; set; }

    public int? IdDdtCausale { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public int? IdDdtAspetto { get; set; }

    public int? IdDdtResa { get; set; }

    public int? IdPag { get; set; }

    public int? IdOrdRiga { get; set; }

    public DateTime? DataExp { get; set; }

    public string? Nota { get; set; }

    public int? CkControllo { get; set; }

    public int? IdBox { get; set; }

    public string? Causale { get; set; }

    public string? TraspCura { get; set; }

    public string? Vettore { get; set; }

    public string? ResaCod { get; set; }

    public int? IdOrd { get; set; }

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

    public int? IdBpriga { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public string? PagCod { get; set; }

    public string? PagDesc { get; set; }

    public string? CatMerc { get; set; }

    public string? MadeIn { get; set; }

    public string? Op { get; set; }

    public string? Gender { get; set; }

    public string? Hscode { get; set; }

    public string? Kw { get; set; }

    public string? Composizione { get; set; }

    public int? IdSetGroup { get; set; }

    public string? SetGroup { get; set; }

    public DateTime? DataInitTrasp { get; set; }

    public string? CdAll { get; set; }

    public string? CdAllcol { get; set; }

    public string? CdAllmis { get; set; }

    public string? Um { get; set; }

    public string NrPezza { get; set; } = null!;

    public string Lotto { get; set; } = null!;

    public decimal? Qta { get; set; }

    public string? Parte { get; set; }

    public string? ParteMis { get; set; }

    public string? Tipo { get; set; }

    public int? IdSetOrd { get; set; }

    public string? TipoOrd { get; set; }

    public bool? CkBp { get; set; }

    public bool? CkComm { get; set; }
}

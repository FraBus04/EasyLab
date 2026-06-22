using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VDocExp2
{
    public int Id { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public int? IdDoc { get; set; }

    public int? IdTipoDoc { get; set; }

    public string? TipoDoc { get; set; }

    public int? IdTipoDati { get; set; }

    public string? Stato { get; set; }

    public int IdMod { get; set; }

    public int IdModCol { get; set; }

    public short? Nr1 { get; set; }

    public short? Nr2 { get; set; }

    public short? Nr3 { get; set; }

    public short? Nr4 { get; set; }

    public short? Nr5 { get; set; }

    public short? Nr6 { get; set; }

    public short? Nr7 { get; set; }

    public short? Nr8 { get; set; }

    public short? Nr9 { get; set; }

    public short? Nr10 { get; set; }

    public short? Nr11 { get; set; }

    public short? Nr12 { get; set; }

    public short? Nr13 { get; set; }

    public short? Nr14 { get; set; }

    public short? Nr15 { get; set; }

    public short? Nr16 { get; set; }

    public short? Nr17 { get; set; }

    public short? Nr18 { get; set; }

    public short? Nr19 { get; set; }

    public short? Nr20 { get; set; }

    public int? TotCapi { get; set; }

    public string? CdMag1 { get; set; }

    public string? CdMag2 { get; set; }

    public string? NrDoc { get; set; }

    public DateOnly? DataDoc { get; set; }

    public DateOnly? DataMov { get; set; }

    public int? IdCcli { get; set; }

    public string? Anag1 { get; set; }

    public int? IdCcliDest { get; set; }

    public string? Anag1Dest { get; set; }

    public bool? Aperto { get; set; }

    public int? TotCapiTesta { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public int? IdStagTesta { get; set; }

    public string? StagTesta { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

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

    public string? Tg17 { get; set; }

    public string? Tg18 { get; set; }

    public string? Tg19 { get; set; }

    public string? Tg20 { get; set; }

    public double? KgTot { get; set; }

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

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? CausaleCod { get; set; }

    public string? Causale { get; set; }

    public string? TraspCuraCod { get; set; }

    public string? TraspCura { get; set; }

    public string? VettoreCod { get; set; }

    public string? Vettore { get; set; }

    public string? ResaCod { get; set; }

    public string? Resa { get; set; }

    public int? IdOrd { get; set; }

    public string? OrdTipo { get; set; }

    public int? OrdNr { get; set; }

    public DateTime? OrdData { get; set; }

    public string? StatoExp { get; set; }

    public long? IdErpDoc { get; set; }

    public int? IdErpRiga { get; set; }

    public int? IdImport { get; set; }

    public int? IdImport2 { get; set; }

    public string? Po { get; set; }

    public DateTime? DataConsDa { get; set; }

    public DateTime? DataConsA { get; set; }

    public string? NotaTestaOrd { get; set; }

    public string? NotaDoc { get; set; }

    public int? IdPriorita { get; set; }

    public string? CodMagBp { get; set; }

    public string? MagPrel { get; set; }

    public string? MagCarico { get; set; }

    public int? IdRagg1 { get; set; }

    public int? IdOrdRiga { get; set; }

    public string? PagCod { get; set; }

    public string? PagDesc { get; set; }

    public string? CodIva { get; set; }

    public string? Nazione { get; set; }

    public int? CkNazioneUe { get; set; }

    public string? TipoDocErp { get; set; }

    public int? IdTipoAnagStake { get; set; }

    public string? RifIdContatto { get; set; }

    public string? RifIdContattoDest { get; set; }

    public string? Comp1 { get; set; }

    public string? Mid { get; set; }

    public string? Hscode { get; set; }
}

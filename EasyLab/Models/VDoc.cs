using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VDoc
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public byte[]? ContattoImg { get; set; }

    public string? ContattoSocieta2 { get; set; }

    public string? ContattoVia { get; set; }

    public string? ContattoCap { get; set; }

    public string? ContattoCitta { get; set; }

    public string? ContattoProv { get; set; }

    public string? ContattoEmail { get; set; }

    public string? ContattoTel { get; set; }

    public string? ContattoNota { get; set; }

    public string? PathLogo { get; set; }

    public int? IdDoc { get; set; }

    public int? IdTipoDoc { get; set; }

    public string? TipoDoc { get; set; }

    public string? TipoDocDesc { get; set; }

    public int? IdTipoDati { get; set; }

    public string? Stato { get; set; }

    public string? CdAll { get; set; }

    public string? CdAllcol { get; set; }

    public string? CdAllmis { get; set; }

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

    public string? FattAnag2 { get; set; }

    public string? FattVia { get; set; }

    public string? FattCap { get; set; }

    public string? FattProv { get; set; }

    public string? FattCitta { get; set; }

    public string? FattNazione { get; set; }

    public string? FattPiva { get; set; }

    public string? FattCf { get; set; }

    public int? IdCcliDest { get; set; }

    public string? Anag1Dest { get; set; }

    public string? DestAnag2 { get; set; }

    public string? DestVia { get; set; }

    public string? DestCap { get; set; }

    public string? DestProv { get; set; }

    public string? DestCitta { get; set; }

    public string? DestNazione { get; set; }

    public bool? Aperto { get; set; }

    public int? TotCapiTesta { get; set; }

    public int IdStag { get; set; }

    public string? Stag { get; set; }

    public int? IdStagTesta { get; set; }

    public string? StagTesta { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string CodCol { get; set; } = null!;

    public string DescCol { get; set; } = null!;

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

    public string IdSetDesc { get; set; } = null!;

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

    public string Tg17 { get; set; } = null!;

    public string Tg18 { get; set; } = null!;

    public string Tg19 { get; set; } = null!;

    public string Tg20 { get; set; } = null!;

    public decimal? KgTot { get; set; }

    public int? NrColli { get; set; }

    public int? IdDdtCausale { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public int? IdDdtAspetto { get; set; }

    public int? IdDdtResa { get; set; }

    public int? IdPag { get; set; }

    public int? IdOrdRiga { get; set; }

    public bool? FlagGiaExp { get; set; }

    public DateTime? DataExp { get; set; }

    public string? Nota { get; set; }

    public int? CkControllo { get; set; }

    public int? IdBox { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? Causale { get; set; }

    public string? TraspCura { get; set; }

    public string? Vettore { get; set; }

    public string? ResaCod { get; set; }

    public int? IdOrd { get; set; }

    public string? OrdTipo { get; set; }

    public int? OrdNr { get; set; }

    public DateTime? OrdData { get; set; }

    public string? StatoExp { get; set; }

    public long? IdErpDoc { get; set; }

    public int? IdErpRiga { get; set; }

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

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public string NrPezza { get; set; } = null!;

    public string Lotto { get; set; } = null!;

    public bool? CkStampa { get; set; }

    public decimal? Qta { get; set; }

    public int? IdMpscar { get; set; }

    public int? IdOrdMp { get; set; }

    public int? IdOrdMpriga { get; set; }

    public short? Hutile { get; set; }

    public int? IdBpriga { get; set; }

    public int IdModNoStag { get; set; }

    public int IdModColNoStag { get; set; }

    public string? PagCod { get; set; }

    public string? PagDesc { get; set; }

    public string? CatMerc { get; set; }

    public string? MadeIn { get; set; }

    public string? Op { get; set; }

    public string? Mid { get; set; }

    public string? Gender { get; set; }

    public string? Hscode { get; set; }

    public string? Kw { get; set; }

    public string? Composizione { get; set; }

    public int? IdExpTesta { get; set; }

    public int? IdExpRiga { get; set; }

    public int? IdCodIva { get; set; }

    public string? CodIva { get; set; }

    public string? CodIvaDesc { get; set; }

    public int IdSetGroup { get; set; }

    public decimal? Cambio { get; set; }

    public int IdSet { get; set; }

    public int? IdModDa { get; set; }

    public int? IdModColDa { get; set; }

    public int? Nr1Da { get; set; }

    public int? Nr2Da { get; set; }

    public int? Nr3Da { get; set; }

    public int? Nr4Da { get; set; }

    public int? Nr5Da { get; set; }

    public int? Nr6Da { get; set; }

    public int? Nr7Da { get; set; }

    public int? Nr8Da { get; set; }

    public int? Nr9Da { get; set; }

    public int? Nr10Da { get; set; }

    public int? Nr11Da { get; set; }

    public int? Nr12Da { get; set; }

    public int? Nr13Da { get; set; }

    public int? Nr14Da { get; set; }

    public int? Nr15Da { get; set; }

    public int? Nr16Da { get; set; }

    public int? TotCapiDa { get; set; }

    public string? ModDa { get; set; }

    public string? TessDa { get; set; }

    public string? ModColDa { get; set; }

    public string? DescColDa { get; set; }

    public string? NomeDa { get; set; }

    public int? ProgRiga { get; set; }

    public int? IdRigaCar { get; set; }

    public string? ContattoRif { get; set; }

    public bool CkImpegna { get; set; }
}

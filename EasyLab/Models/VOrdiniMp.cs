using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VOrdiniMp
{
    public int Id { get; set; }

    public string? StatoTesta { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public int IdTesta { get; set; }

    public int? IdCcliForn { get; set; }

    public string? Forn { get; set; }

    public string? NrOrd { get; set; }

    public string? TipoOrd { get; set; }

    public string? CdValuta { get; set; }

    public DateOnly? DataOrd { get; set; }

    public string? NotaTesta { get; set; }

    public string StatoRiga { get; set; } = null!;

    public int ProgRiga { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public int? IdLinea { get; set; }

    public string? Linea { get; set; }

    public int IdMat { get; set; }

    public string? Mat { get; set; }

    public string? DescMat { get; set; }

    public string? Um { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public string? CodColForn { get; set; }

    public string? Misura { get; set; }

    public string? DescMis { get; set; }

    public string? DescMisForn { get; set; }

    public double QtOrd { get; set; }

    public double QtArr { get; set; }

    public string? CodMag { get; set; }

    public string FlagSaldo { get; set; } = null!;

    public DateTime? DataPrev { get; set; }

    public DateTime? DataArr { get; set; }

    public double? Prezzo { get; set; }

    public double? Sconto { get; set; }

    public string? FlagConf { get; set; }

    public double? QtDaConf { get; set; }

    public double? QtTotOrdAperto { get; set; }

    public double? QtTotDaRicevere { get; set; }

    public string? NotaRiga { get; set; }

    public string? FlagNota { get; set; }

    public int? Sett { get; set; }

    public double? N1 { get; set; }

    public double? N2 { get; set; }

    public double? N3 { get; set; }

    public double? N4 { get; set; }

    public double? N5 { get; set; }

    public double? N6 { get; set; }

    public double? N7 { get; set; }

    public double? N8 { get; set; }

    public double? N9 { get; set; }

    public double? N10 { get; set; }

    public double? N11 { get; set; }

    public double? N12 { get; set; }

    public double? N13 { get; set; }

    public double? N14 { get; set; }

    public double? N15 { get; set; }

    public double? N16 { get; set; }

    public double? N17 { get; set; }

    public double? N18 { get; set; }

    public double? N19 { get; set; }

    public double? N20 { get; set; }

    public DateTime? D1 { get; set; }

    public DateTime? D2 { get; set; }

    public DateTime? D3 { get; set; }

    public DateTime? D4 { get; set; }

    public DateTime? D5 { get; set; }

    public DateTime? D6 { get; set; }

    public DateTime? D7 { get; set; }

    public DateTime? D8 { get; set; }

    public DateTime? D9 { get; set; }

    public DateTime? D10 { get; set; }

    public DateTime? D11 { get; set; }

    public DateTime? D12 { get; set; }

    public DateTime? D13 { get; set; }

    public DateTime? D14 { get; set; }

    public DateTime? D15 { get; set; }

    public DateTime? D16 { get; set; }

    public DateTime? D17 { get; set; }

    public DateTime? D18 { get; set; }

    public DateTime? D19 { get; set; }

    public DateTime? D20 { get; set; }

    public string? W1 { get; set; }

    public string? W2 { get; set; }

    public string? W3 { get; set; }

    public string? W4 { get; set; }

    public string? W5 { get; set; }

    public string? W6 { get; set; }

    public string? W7 { get; set; }

    public string? W8 { get; set; }

    public string? W9 { get; set; }

    public string? W10 { get; set; }

    public string? W11 { get; set; }

    public string? W12 { get; set; }

    public string? W13 { get; set; }

    public string? W14 { get; set; }

    public string? W15 { get; set; }

    public string? W16 { get; set; }

    public string? W17 { get; set; }

    public string? W18 { get; set; }

    public string? W19 { get; set; }

    public string? W20 { get; set; }

    public string CdStatoOrdMp { get; set; } = null!;

    public string? Anag1 { get; set; }

    public string? Anag2 { get; set; }

    public string? Via { get; set; }

    public string? CapNew { get; set; }

    public string? Citta { get; set; }

    public string? Prov { get; set; }

    public string? Nazione { get; set; }

    public string? CodArtFornitore { get; set; }

    public int? LeadTimeGg { get; set; }

    public string? MinProd { get; set; }

    public string? LungPezze { get; set; }

    public string? CdTipoMat { get; set; }

    public string? PathImg { get; set; }

    public bool? CkMatMis { get; set; }

    public double? ValOrd { get; set; }

    public string? StatoOrdMptesta { get; set; }

    public string? StatoOrdMpriga { get; set; }

    public int IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public double? PercArr { get; set; }

    public string? PagamentoCod { get; set; }

    public string? Pagamento { get; set; }

    public string? TraspCuraCod { get; set; }

    public string? TraspCura { get; set; }

    public string? VettoreCod { get; set; }

    public string? Vettore { get; set; }

    public string? Anag1Dest { get; set; }

    public string? Anag2Dest { get; set; }

    public string? ViaDest { get; set; }

    public string? CapNewDest { get; set; }

    public string? CittaDest { get; set; }

    public string? ProvDest { get; set; }

    public string? NazioneDest { get; set; }

    public string? Po { get; set; }

    public int? IdResa { get; set; }

    public string? ResaCod { get; set; }

    public string? ResaDesc { get; set; }

    public int? FlagConfInt { get; set; }

    public string? StatoApp { get; set; }

    public string? StatoAppDesc { get; set; }

    public int? IdUteApp { get; set; }

    public string? UteApp { get; set; }

    public DateTime? DateApp { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? PathFirma { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataExp { get; set; }

    public string? CcliRifidContatto { get; set; }

    public string? CcliDestRifidContatto { get; set; }

    public bool? LockRiga { get; set; }

    public int? ProgRigaMat { get; set; }

    public int? IdImportCcli { get; set; }

    public DateTime? Expr1 { get; set; }

    public string? Azione { get; set; }

    public double? ScontoTesta { get; set; }

    public double? Sco1 { get; set; }

    public int? IdTipoMat { get; set; }

    public int? OrdTipoMat { get; set; }

    public string? TipoOrdDesc { get; set; }

    public string MatCol { get; set; } = null!;

    public string MatMis { get; set; } = null!;

    public string? ContattoSocieta2 { get; set; }

    public string? ContattoCell { get; set; }

    public string? ContattoTel { get; set; }

    public string? ContattoEmail { get; set; }

    public string? ContattoVia { get; set; }

    public string? ContattoCap { get; set; }

    public string? ContattoCitta { get; set; }

    public string? ContattoProv { get; set; }

    public byte[]? ContattoImg { get; set; }

    public bool? CkSemilav { get; set; }

    public string? TelForn { get; set; }

    public string? TelDest { get; set; }
}

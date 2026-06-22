using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzGeneCommesse
{
    public int? Id { get; set; }

    public int IdCommessa { get; set; }

    public string? Stato { get; set; }

    public int? IdContatto { get; set; }

    public int? IdStag { get; set; }

    public int? IdLab { get; set; }

    public int IdMod { get; set; }

    public int? IdModCol { get; set; }

    public string? Contatto { get; set; }

    public int? NrScheda { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Variante { get; set; }

    public DateOnly? DataComm { get; set; }

    public string? Col { get; set; }

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

    public DateOnly? OrdData { get; set; }

    public int? Ccli { get; set; }

    public string? Anag1 { get; set; }

    public string? Stag { get; set; }

    public int? OrdNr { get; set; }

    public string? DescCol { get; set; }

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

    public int? TotCapi { get; set; }

    public string? StatoModCod { get; set; }

    public string? StatoMod { get; set; }

    public string? Cad { get; set; }

    public string OrdTipo { get; set; } = null!;

    public string? OrdTipoDesc { get; set; }

    public string? LabDesc { get; set; }

    public DateTime? DataRicRientro { get; set; }

    public string? Nome { get; set; }

    public DateTime? DataConfRientro { get; set; }

    public bool? CkConf { get; set; }

    public bool? CkInvMatLogistTesta { get; set; }

    public string StatoTesta { get; set; } = null!;

    public int? TotCapiTesta { get; set; }

    public string SaldoTesta { get; set; } = null!;

    public string? NotaTesta { get; set; }

    public string? StatoCommessaTesta { get; set; }

    public string? PathImg { get; set; }

    public string? PathImgCol { get; set; }

    public int? IdRigaOrd { get; set; }

    public int? IdImport { get; set; }

    public string? CdValuta { get; set; }

    public double? Prezzo { get; set; }

    public int? CkExp { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataExp { get; set; }

    public int? IdFase { get; set; }

    public string? FaseCod { get; set; }

    public string? FaseDesc { get; set; }

    public string? StagDesc { get; set; }

    public string? StagAnno { get; set; }

    public int? IdCcli { get; set; }

    public string? Forn { get; set; }

    public int? IdCcliDest { get; set; }

    public string? FornDest { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public string? TraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public string? Vettore { get; set; }

    public string? Po { get; set; }

    public int? IdPag { get; set; }

    public string? Pagamento { get; set; }

    public string? PoOrdCli { get; set; }

    public string? Lotto { get; set; }

    public double? RitX { get; set; }

    public double? RitY { get; set; }

    public short? Peso { get; set; }

    public string? Trattamento { get; set; }

    public string? Imballo { get; set; }

    public string? Stiro { get; set; }

    public DateOnly? DataConsOrd { get; set; }

    public string? Citta { get; set; }

    public string? Nazione { get; set; }

    public string? OrdOrdTipo { get; set; }

    public string? OrdOrdTipoDesc { get; set; }

    public string? DescBreve { get; set; }

    public string? Ragg1Desc { get; set; }

    public string? ACdAll { get; set; }

    public string? ACdAllcol { get; set; }

    public string? Parte { get; set; }

    public string? ParteDesc { get; set; }

    public string? ParteCol { get; set; }

    public string? ParteColDesc { get; set; }

    public string? ParteMis { get; set; }

    public double? Qta { get; set; }

    public string? Um { get; set; }

    public string? CodArtFornitore { get; set; }

    public string? CodColForn { get; set; }
}

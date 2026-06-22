using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VImpOrdiniPf
{
    public int Id { get; set; }

    public int? IdOrdImp { get; set; }

    public string? Stato { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? StagOrd { get; set; }

    public long? IdErpOrd { get; set; }

    public int? IdErpRiga { get; set; }

    public string? OrdTipo { get; set; }

    public int? OrdNr { get; set; }

    public DateOnly? OrdData { get; set; }

    public int? Ccli { get; set; }

    public string? Anag1 { get; set; }

    public string? Anag2 { get; set; }

    public string? Via { get; set; }

    public string? CapNew { get; set; }

    public string? Citta { get; set; }

    public string? Prov { get; set; }

    public string? Nazione { get; set; }

    public int? CcliDest { get; set; }

    public string? Anag1Dest { get; set; }

    public string? Anag2Dest { get; set; }

    public string? ViaDest { get; set; }

    public string? CapNewDest { get; set; }

    public string? CittaDest { get; set; }

    public string? ProvDest { get; set; }

    public string? NazioneDest { get; set; }

    public int? IdAg { get; set; }

    public string? Ag { get; set; }

    public DateOnly? DataConsDa { get; set; }

    public DateOnly? DataConsA { get; set; }

    public string? Po { get; set; }

    public int? IdTipoList { get; set; }

    public string? CdTipoListino { get; set; }

    public string? TipoListinoDesc { get; set; }

    public int? IdPag { get; set; }

    public string? PagCod { get; set; }

    public string? PagDesc { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public string? TraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public string? Vettore { get; set; }

    public int? IdDdtResa { get; set; }

    public string? Resa { get; set; }

    public double? CostiTrasp { get; set; }

    public double? CostiAltri { get; set; }

    public int? IdCodIva { get; set; }

    public int? IdStagMod { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModColNoStag { get; set; }

    public string? StagMod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public int? ProgRiga { get; set; }

    public double? PzArt { get; set; }

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

    public int? TotCapi { get; set; }

    public string? CodMag { get; set; }

    public string? NotaRiga { get; set; }

    public string? MagPrel { get; set; }

    public DateOnly? DataCons { get; set; }

    public string? StatoImp { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdSet { get; set; }

    public int? IdSetGroup { get; set; }

    public string? CdValuta { get; set; }

    public bool? CkErr { get; set; }

    public int? IdStag { get; set; }

    public int? IdModNoStag { get; set; }
}

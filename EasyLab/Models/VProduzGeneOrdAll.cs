using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzGeneOrdAll
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public string? StatoTesta { get; set; }

    public int IdStag { get; set; }

    public string? AnnoDesc { get; set; }

    public string? StagOrd { get; set; }

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string OrdTipo { get; set; } = null!;

    public int OrdNr { get; set; }

    public DateTime? OrdData { get; set; }

    public int? Ccli { get; set; }

    public int? CcliDest { get; set; }

    public int? ProgRiga { get; set; }

    public int IdMod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? Variante { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public string? ColOrd { get; set; }

    public string? CodProd { get; set; }

    public double? PzArt { get; set; }

    public int? Nr1 { get; set; }

    public int? Nr2 { get; set; }

    public int? Nr3 { get; set; }

    public int? Nr4 { get; set; }

    public int? Nr5 { get; set; }

    public int? Nr6 { get; set; }

    public int? Nr7 { get; set; }

    public int? Nr8 { get; set; }

    public int? Nr9 { get; set; }

    public int? Nr10 { get; set; }

    public int? Nr11 { get; set; }

    public int? TotCapi { get; set; }

    public string? CodMag { get; set; }

    public DateOnly? DataCons { get; set; }

    public string? StrVettore { get; set; }

    public string? StrPorto { get; set; }

    public string? StrPagamento { get; set; }

    public string? StrNota { get; set; }

    public string? RifIdContatto { get; set; }

    public int? IdOrd { get; set; }

    public int? NrCommessa { get; set; }

    public short? Nr111 { get; set; }

    public short? Nr12 { get; set; }

    public short? Nr13 { get; set; }

    public short? Nr14 { get; set; }

    public short? Nr15 { get; set; }

    public short? Nr16 { get; set; }

    public short? Nr17 { get; set; }

    public short? Nr18 { get; set; }

    public short? Nr19 { get; set; }

    public short? Nr110 { get; set; }

    public short? Nr1111 { get; set; }

    public short? Nr51 { get; set; }

    public short? Nr52 { get; set; }

    public short? Nr53 { get; set; }

    public short? Nr54 { get; set; }

    public short? Nr55 { get; set; }

    public short? Nr56 { get; set; }

    public short? Nr57 { get; set; }

    public short? Nr58 { get; set; }

    public short? Nr59 { get; set; }

    public short? Nr510 { get; set; }

    public short? Nr511 { get; set; }

    public short? Nr61 { get; set; }

    public short? Nr62 { get; set; }

    public short? Nr63 { get; set; }

    public short? Nr64 { get; set; }

    public short? Nr65 { get; set; }

    public short? Nr66 { get; set; }

    public short? Nr67 { get; set; }

    public short? Nr68 { get; set; }

    public short? Nr69 { get; set; }

    public short? Nr610 { get; set; }

    public short? Nr611 { get; set; }

    public short? Nr71 { get; set; }

    public short? Nr72 { get; set; }

    public short? Nr73 { get; set; }

    public short? Nr74 { get; set; }

    public short? Nr75 { get; set; }

    public short? Nr76 { get; set; }

    public short? Nr77 { get; set; }

    public short? Nr78 { get; set; }

    public short? Nr79 { get; set; }

    public short? Nr710 { get; set; }

    public short? Nr711 { get; set; }

    public short? TotNr1 { get; set; }

    public short? TotNr5 { get; set; }

    public short? TotNr6 { get; set; }

    public short? TotNr7 { get; set; }

    public int? NrDdt { get; set; }

    public int? IdLab { get; set; }

    public DateOnly? DataPrevMag { get; set; }

    public string? St1 { get; set; }

    public string? St2 { get; set; }

    public string? St3 { get; set; }

    public string? St4 { get; set; }

    public string? St5 { get; set; }

    public string? St6 { get; set; }

    public string? St7 { get; set; }

    public string? St8 { get; set; }

    public string? St9 { get; set; }

    public string? St10 { get; set; }

    public string? St11 { get; set; }

    public string? L { get; set; }

    public DateOnly? DataConsDa { get; set; }

    public DateOnly? DataConsA { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public short? Nr21 { get; set; }

    public short? Nr22 { get; set; }

    public short? Nr23 { get; set; }

    public short? Nr24 { get; set; }

    public short? Nr25 { get; set; }

    public short? Nr26 { get; set; }

    public short? Nr27 { get; set; }

    public short? Nr28 { get; set; }

    public short? Nr29 { get; set; }

    public short? Nr210 { get; set; }

    public short? Nr211 { get; set; }

    public short? TotNr2 { get; set; }

    public string? PathImgMod { get; set; }

    public string? CcliAnag1 { get; set; }

    public string? CcliAnag2 { get; set; }

    public string? CcliVia { get; set; }

    public string? CcliCap { get; set; }

    public string? CcliCitta { get; set; }

    public string? CcliProv { get; set; }

    public string? CcliChiedere { get; set; }

    public int? IdCatMerc { get; set; }

    public string? Po { get; set; }

    public int? IdTipoCli { get; set; }

    public string? CatMercMacroCod { get; set; }

    public string? CatMercMacroDesc { get; set; }

    public string? CodUbic { get; set; }

    public bool? Sped { get; set; }

    public bool? Saldo { get; set; }

    public bool? PosMagPrint { get; set; }

    public int? IdDdt { get; set; }

    public int? IdComm { get; set; }

    public string? StagMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdCanale { get; set; }

    public string? Canale { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataExp { get; set; }

    public DateTime? DataImp { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public string? TraspCura { get; set; }

    public int? IdPag { get; set; }

    public string? PagCod { get; set; }

    public string? PagDesc { get; set; }

    public int? IdDdtResa { get; set; }

    public string? ResaCod { get; set; }

    public string? ResaDesc { get; set; }

    public int? IdTipoList { get; set; }

    public string? TipoListCod { get; set; }

    public string? TipoListDesc { get; set; }

    public int? IdDdtVettore { get; set; }

    public string? Vettore { get; set; }

    public string? CdValuta { get; set; }

    public int? CcliIdImport { get; set; }

    public int? CcliIdImport2 { get; set; }

    public int? CcliDestIdImport { get; set; }

    public int? CcliDestIdImport2 { get; set; }
}

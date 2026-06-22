using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzGeneOrd
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public string Stato { get; set; } = null!;

    public int IdStag { get; set; }

    public int? IdStagMod { get; set; }

    public string? Stag { get; set; }

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string OrdTipo { get; set; } = null!;

    public int OrdNr { get; set; }

    public DateTime? OrdData { get; set; }

    public int Ccli { get; set; }

    public int? CcliDest { get; set; }

    public int? ProgRiga { get; set; }

    public string? TipoModello { get; set; }

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

    public int? Nr12 { get; set; }

    public int? Nr13 { get; set; }

    public int? Nr14 { get; set; }

    public int? Nr15 { get; set; }

    public int? Nr16 { get; set; }

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

    public short? Nr121 { get; set; }

    public short? Nr131 { get; set; }

    public short? Nr141 { get; set; }

    public short? Nr151 { get; set; }

    public short? Nr161 { get; set; }

    public short? Nr17 { get; set; }

    public short? Nr18 { get; set; }

    public short? Nr19 { get; set; }

    public short? Nr110 { get; set; }

    public short? Nr1111 { get; set; }

    public short? Nr112 { get; set; }

    public short? Nr113 { get; set; }

    public short? Nr114 { get; set; }

    public short? Nr115 { get; set; }

    public short? Nr116 { get; set; }

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

    public short? Nr212 { get; set; }

    public short? Nr213 { get; set; }

    public short? Nr214 { get; set; }

    public short? Nr215 { get; set; }

    public short? Nr216 { get; set; }

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

    public short? Nr512 { get; set; }

    public short? Nr513 { get; set; }

    public short? Nr514 { get; set; }

    public short? Nr515 { get; set; }

    public short? Nr516 { get; set; }

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

    public short? Nr612 { get; set; }

    public short? Nr613 { get; set; }

    public short? Nr614 { get; set; }

    public short? Nr615 { get; set; }

    public short? Nr616 { get; set; }

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

    public short? Nr712 { get; set; }

    public short? Nr713 { get; set; }

    public short? Nr714 { get; set; }

    public short? Nr715 { get; set; }

    public short? Nr716 { get; set; }

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

    public string? St12 { get; set; }

    public string? St13 { get; set; }

    public string? St14 { get; set; }

    public string? St15 { get; set; }

    public string? St16 { get; set; }

    public string? L { get; set; }

    public DateTime? DataConsDa { get; set; }

    public DateTime? DataConsA { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public short? TotNr2 { get; set; }

    public int? TotNr0 { get; set; }

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

    public int? IdCatMercMacro2 { get; set; }

    public string? CatMercMacroCod2 { get; set; }

    public string? CatMercMacroDesc2 { get; set; }

    public int? IdCatMerc2 { get; set; }

    public string? CatMercCod2 { get; set; }

    public string? CatMercDesc2 { get; set; }

    public string? MagPrel { get; set; }

    public int? IdVoto { get; set; }

    public string? Voto { get; set; }

    public string? VotoCod { get; set; }

    public int? VotoOrd { get; set; }

    public string? CdValuta { get; set; }

    public string? DescCol { get; set; }

    public int? IdSet { get; set; }

    public int? IdAg { get; set; }

    public int? IdRagg1Ord { get; set; }

    public int? IdRagg2Ord { get; set; }

    public int? IdRagg3Ord { get; set; }

    public string? LabPrev { get; set; }

    public int? IdCatMercMacro { get; set; }

    public int? IdPag { get; set; }

    public string? ResaCod { get; set; }

    public int? IdDdtResa { get; set; }

    public string? NotaTesta { get; set; }

    public int? IdErpRiga { get; set; }

    public int? ProgPadre { get; set; }

    public double? PzArtEuro { get; set; }
}

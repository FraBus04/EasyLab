using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzGeneOrdDivStati
{
    public int Id { get; set; }

    public int IdUte { get; set; }

    public int IdOrd { get; set; }

    public string Stato { get; set; } = null!;

    public int IdStag { get; set; }

    public int IdContatto { get; set; }

    public string OrdTipo { get; set; } = null!;

    public int OrdNr { get; set; }

    public DateTime? OrdData { get; set; }

    public int Ccli { get; set; }

    public int? CcliDest { get; set; }

    public int IdRiga { get; set; }

    public int IdStato { get; set; }

    public int? IdMod { get; set; }

    public string Mod { get; set; } = null!;

    public string? Tess { get; set; }

    public string? Variante { get; set; }

    public string? ColOrd { get; set; }

    public string? CodProd { get; set; }

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

    public short? St1 { get; set; }

    public short? St2 { get; set; }

    public short? St3 { get; set; }

    public short? St4 { get; set; }

    public short? St5 { get; set; }

    public short? St6 { get; set; }

    public short? St7 { get; set; }

    public short? St8 { get; set; }

    public short? St9 { get; set; }

    public short? St10 { get; set; }

    public short? St11 { get; set; }

    public short? St12 { get; set; }

    public short? St13 { get; set; }

    public short? St14 { get; set; }

    public short? St15 { get; set; }

    public short? St16 { get; set; }

    public int? TotSt { get; set; }

    public string? Anag1 { get; set; }

    public string? Anag2 { get; set; }

    public string? Via { get; set; }

    public string? CapNew { get; set; }

    public string? Citta { get; set; }

    public string? Prov { get; set; }

    public string? NazioneCod { get; set; }

    public string? Nazione { get; set; }

    public DateOnly? DataCons { get; set; }

    public DateOnly? DataPrevMag { get; set; }

    public int? NrDdt { get; set; }

    public string? Contatto { get; set; }

    public string? ContattoPathLogo { get; set; }

    public string? Nome { get; set; }

    public string? HsCode { get; set; }

    public string? Kw { get; set; }

    public string? DescCommerc { get; set; }

    public string? Composizione { get; set; }

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

    public string? DescCol { get; set; }

    public string? PathImgMod { get; set; }

    public string? PathImgCol { get; set; }

    public string? CatMercCod { get; set; }

    public string? CadMercDesc { get; set; }

    public string? RifIdContatto { get; set; }

    public string? StagCod { get; set; }

    public string? StagDesc { get; set; }

    public string? MadeInCod { get; set; }

    public string? MadeInDesc { get; set; }

    public string? Po { get; set; }

    public int? NrCommessa { get; set; }

    public DateTime? NrCommessaData { get; set; }

    public string? RigaOrdNota { get; set; }

    public string? Lr { get; set; }

    public string? Lab { get; set; }

    public string? CodUbic { get; set; }

    public int? TotVend { get; set; }

    public int? TotRecup { get; set; }

    public int? TotDaLanc { get; set; }

    public int? TotLanc { get; set; }

    public int? TotMag { get; set; }

    public int? TotSped { get; set; }

    public int? TotAnn { get; set; }

    public double? TotVendVal { get; set; }

    public double? TotRecupVal { get; set; }

    public double? TotDaLancVal { get; set; }

    public double? TotLancVal { get; set; }

    public double? TotMagVal { get; set; }

    public double? TotSpedVal { get; set; }

    public double? TotAnnVal { get; set; }

    public double? PTotDaLanc { get; set; }

    public double? PTotMag { get; set; }

    public double? PTotSped { get; set; }

    public double? PTotAnn { get; set; }

    public double? PTotDaRientrare { get; set; }

    public double? PTotNoDate { get; set; }

    public double? PTotDaLancVal { get; set; }

    public double? PTotMagVal { get; set; }

    public double? PTotSpedVal { get; set; }

    public double? PTotAnnVal { get; set; }

    public double? PTotDaRientrareVal { get; set; }

    public double? PTotNoDateVal { get; set; }

    public int? TotNoDate { get; set; }

    public double? TotNoDateVal { get; set; }

    public int? TotDaRientrare { get; set; }

    public double? TotDaRientrareVal { get; set; }

    public int? TotScad { get; set; }

    public double? TotScadVal { get; set; }

    public int? Wk1 { get; set; }

    public int? Wk2 { get; set; }

    public int? Wk3 { get; set; }

    public int? Wk4 { get; set; }

    public int? Wk5 { get; set; }

    public int? Wk6 { get; set; }

    public int? Wk7 { get; set; }

    public int? Wk8 { get; set; }

    public int? Wk9 { get; set; }

    public int? Wk10 { get; set; }

    public int? Wk11 { get; set; }

    public int? Wk12 { get; set; }

    public int? Wk13 { get; set; }

    public int? Wk14 { get; set; }

    public int? Wk15 { get; set; }

    public int? Wk16 { get; set; }

    public int? Wk17 { get; set; }

    public int? Wk18 { get; set; }

    public int? Wk19 { get; set; }

    public int? Wk20 { get; set; }

    public string? Lab1 { get; set; }

    public string? Lab2 { get; set; }

    public string? Lab3 { get; set; }

    public string? Lab4 { get; set; }

    public string? Lab5 { get; set; }

    public string? Lab6 { get; set; }

    public string? Lab7 { get; set; }

    public string? Lab8 { get; set; }

    public string? Lab9 { get; set; }

    public string? Lab10 { get; set; }

    public string? Lab11 { get; set; }

    public string? Lab12 { get; set; }

    public string? Lab13 { get; set; }

    public string? Lab14 { get; set; }

    public string? Lab15 { get; set; }

    public string? Lab16 { get; set; }

    public string? Lab17 { get; set; }

    public string? Lab18 { get; set; }

    public string? Lab19 { get; set; }

    public string? Lab20 { get; set; }

    public int? Capi1 { get; set; }

    public int? Capi2 { get; set; }

    public int? Capi3 { get; set; }

    public int? Capi4 { get; set; }

    public int? Capi5 { get; set; }

    public int? Capi6 { get; set; }

    public int? Capi7 { get; set; }

    public int? Capi8 { get; set; }

    public int? Capi9 { get; set; }

    public int? Capi10 { get; set; }

    public int? Capi11 { get; set; }

    public int? Capi12 { get; set; }

    public int? Capi13 { get; set; }

    public int? Capi14 { get; set; }

    public int? Capi15 { get; set; }

    public int? Capi16 { get; set; }

    public int? Capi17 { get; set; }

    public int? Capi18 { get; set; }

    public int? Capi19 { get; set; }

    public int? Capi20 { get; set; }

    public double? Val1 { get; set; }

    public double? Val2 { get; set; }

    public double? Val3 { get; set; }

    public double? Val4 { get; set; }

    public double? Val5 { get; set; }

    public double? Val6 { get; set; }

    public double? Val7 { get; set; }

    public double? Val8 { get; set; }

    public double? Val9 { get; set; }

    public double? Val10 { get; set; }

    public double? Val11 { get; set; }

    public double? Val12 { get; set; }

    public double? Val13 { get; set; }

    public double? Val14 { get; set; }

    public double? Val15 { get; set; }

    public double? Val16 { get; set; }

    public double? Val17 { get; set; }

    public double? Val18 { get; set; }

    public double? Val19 { get; set; }

    public double? Val20 { get; set; }

    public DateTime? Ts { get; set; }

    public byte[]? ImgMod { get; set; }

    public byte[]? ImgModCol { get; set; }

    public int? IdModCol { get; set; }

    public string? Anag1Dest { get; set; }

    public string? Anag2Dest { get; set; }

    public string? ViaDest { get; set; }

    public string? CittaDest { get; set; }

    public string? ProvDest { get; set; }

    public string? CapDest { get; set; }

    public string? NazioneDest { get; set; }

    public string? CdValuta { get; set; }

    public DateTime? DataConsDa { get; set; }

    public DateTime? DataConsA { get; set; }
}

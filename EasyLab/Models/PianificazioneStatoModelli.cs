using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class PianificazioneStatoModelli
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int IdMod { get; set; }

    public int TotVend { get; set; }

    public int TotRecup { get; set; }

    public int TotDaLanc { get; set; }

    public int TotLanc { get; set; }

    public int TotMag { get; set; }

    public int TotSped { get; set; }

    public int TotAnn { get; set; }

    public double TotVendVal { get; set; }

    public double TotRecupVal { get; set; }

    public double TotDaLancVal { get; set; }

    public double TotLancVal { get; set; }

    public double TotMagVal { get; set; }

    public double TotSpedVal { get; set; }

    public double TotAnnVal { get; set; }

    public int? IdCommFirst { get; set; }

    public DateTime? DataCommFirst { get; set; }

    public int? IdLabCommFirst { get; set; }

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

    public int? St1 { get; set; }

    public int? St2 { get; set; }

    public int? St3 { get; set; }

    public int? St4 { get; set; }

    public int? St5 { get; set; }

    public int? St6 { get; set; }

    public int? St7 { get; set; }

    public int? St8 { get; set; }

    public int? St9 { get; set; }

    public int? St10 { get; set; }

    public int? St11 { get; set; }

    public int? St12 { get; set; }

    public int? St13 { get; set; }

    public int? St14 { get; set; }

    public int? St15 { get; set; }

    public int? St16 { get; set; }

    public int? St17 { get; set; }

    public int? St18 { get; set; }

    public int? St19 { get; set; }

    public int? St20 { get; set; }

    public DateOnly? DataPianifProd { get; set; }

    public int? WkDataPianifProd { get; set; }

    public int? WkDataPianifRientro { get; set; }

    public int? LeadTimeGg { get; set; }

    public DateOnly? Date1 { get; set; }

    public DateOnly? Date2 { get; set; }

    public DateOnly? Date3 { get; set; }

    public DateOnly? Date4 { get; set; }

    public DateOnly? Date5 { get; set; }

    public DateOnly? Date6 { get; set; }

    public DateOnly? Date7 { get; set; }

    public DateOnly? Date8 { get; set; }

    public DateOnly? Date9 { get; set; }

    public DateOnly? Date10 { get; set; }

    public DateOnly? Date11 { get; set; }

    public DateOnly? Date12 { get; set; }

    public DateOnly? Date13 { get; set; }

    public DateOnly? Date14 { get; set; }

    public DateOnly? Date15 { get; set; }

    public DateOnly? Date16 { get; set; }

    public DateOnly? Date17 { get; set; }

    public DateOnly? Date18 { get; set; }

    public DateOnly? Date19 { get; set; }

    public DateOnly? Date20 { get; set; }

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

    public int? Modo { get; set; }

    public DateTime? Ts { get; set; }

    public DateOnly? DataPianifRientro { get; set; }

    public int? IdModCol { get; set; }

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

    public int? IdRigaOrd { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class PianifStatoModelli
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string Livello { get; set; } = null!;

    public int IdStag { get; set; }

    public int IdMod { get; set; }

    public int? IdModCol { get; set; }

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

    public int? IdCommFirst { get; set; }

    public DateTime? DataCommFirst { get; set; }

    public int? IdLabCommFirst { get; set; }

    public DateOnly? DataMin { get; set; }

    public DateOnly? DataMax { get; set; }

    public int? WkDataMin { get; set; }

    public int? WkDataMax { get; set; }

    public DateOnly? DataPianifRientro { get; set; }

    public DateOnly? DataRicConsMin { get; set; }

    public DateOnly? DataRicConsMax { get; set; }

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

    public int? Modo { get; set; }

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

    public DateTime? DataIns { get; set; }

    public int? CkMat { get; set; }

    public int? CkOrd { get; set; }

    public int? WkdataPianifProd { get; set; }

    public string? TipoDato { get; set; }

    public int? Wk21 { get; set; }

    public int? Wk22 { get; set; }

    public int? Wk23 { get; set; }

    public int? Wk24 { get; set; }

    public int? Wk25 { get; set; }

    public int? Wk26 { get; set; }

    public int? Wk27 { get; set; }

    public int? Wk28 { get; set; }

    public int? Wk29 { get; set; }

    public int? Wk30 { get; set; }

    public int? St21 { get; set; }

    public int? St22 { get; set; }

    public int? St23 { get; set; }

    public int? St24 { get; set; }

    public int? St25 { get; set; }

    public int? St26 { get; set; }

    public int? St27 { get; set; }

    public int? St28 { get; set; }

    public int? St29 { get; set; }

    public int? St30 { get; set; }

    public DateOnly? Date21 { get; set; }

    public DateOnly? Date22 { get; set; }

    public DateOnly? Date23 { get; set; }

    public DateOnly? Date24 { get; set; }

    public DateOnly? Date25 { get; set; }

    public DateOnly? Date26 { get; set; }

    public DateOnly? Date27 { get; set; }

    public DateOnly? Date28 { get; set; }

    public DateOnly? Date29 { get; set; }

    public DateOnly? Date30 { get; set; }

    public int? Capi21 { get; set; }

    public int? Capi22 { get; set; }

    public int? Capi23 { get; set; }

    public int? Capi24 { get; set; }

    public int? Capi25 { get; set; }

    public int? Capi26 { get; set; }

    public int? Capi27 { get; set; }

    public int? Capi28 { get; set; }

    public int? Capi29 { get; set; }

    public int? Capi30 { get; set; }

    public string? Lab21 { get; set; }

    public string? Lab22 { get; set; }

    public string? Lab23 { get; set; }

    public string? Lab24 { get; set; }

    public string? Lab25 { get; set; }

    public string? Lab26 { get; set; }

    public string? Lab27 { get; set; }

    public string? Lab28 { get; set; }

    public string? Lab29 { get; set; }

    public string? Lab30 { get; set; }

    public string? Text1 { get; set; }

    public string? Text2 { get; set; }

    public string? Text3 { get; set; }

    public string? Text4 { get; set; }

    public string? Text5 { get; set; }

    public string? Text6 { get; set; }

    public string? Text7 { get; set; }

    public string? Text8 { get; set; }

    public string? Text9 { get; set; }

    public string? Text10 { get; set; }

    public string? Text11 { get; set; }

    public string? Text12 { get; set; }

    public string? Text13 { get; set; }

    public string? Text14 { get; set; }

    public string? Text15 { get; set; }

    public string? Text16 { get; set; }

    public string? Text17 { get; set; }

    public string? Text18 { get; set; }

    public string? Text19 { get; set; }

    public string? Text20 { get; set; }

    public string? Text21 { get; set; }

    public string? Text22 { get; set; }

    public string? Text23 { get; set; }

    public string? Text24 { get; set; }

    public string? Text25 { get; set; }

    public string? Text26 { get; set; }

    public string? Text27 { get; set; }

    public string? Text28 { get; set; }

    public string? Text29 { get; set; }

    public string? Text30 { get; set; }

    public string? Text0 { get; set; }
}

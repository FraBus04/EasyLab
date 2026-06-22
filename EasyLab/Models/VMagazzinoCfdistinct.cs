using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VMagazzinoCfdistinct
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdUte { get; set; }

    public int? EanKey { get; set; }

    public string? CdMag { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? TotCapi { get; set; }

    public int? MagAss { get; set; }

    public int? MagDisp { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ModTess { get; set; }

    public string? ModCol { get; set; }

    public string? DescCol { get; set; }

    public string? Nome { get; set; }

    public string? GenderCod { get; set; }

    public string? GenderDesc { get; set; }

    public string? Composizione { get; set; }

    public string? Lav1 { get; set; }

    public string? Lav2 { get; set; }

    public string? Lav3 { get; set; }

    public string? Lav4 { get; set; }

    public string? Lav5 { get; set; }

    public string? Lav6 { get; set; }

    public int? Negativi { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public string? CatMercMacroCod { get; set; }

    public string? CatMercMacroDesc { get; set; }

    public string? CatMercMacroCod2 { get; set; }

    public string? CatMercMacroDesc2 { get; set; }

    public string? CatMercCod2 { get; set; }

    public string? CatMercDesc2 { get; set; }

    public string? StagionalitaCod { get; set; }

    public string? StagionalitaDesc { get; set; }

    public string? MadeIn { get; set; }

    public string? Linea { get; set; }

    public string? StatoPv { get; set; }

    public int? IdClasse { get; set; }

    public bool? CkModCol { get; set; }

    public bool? CkAccorpaMag { get; set; }

    public int? MagDaAss { get; set; }

    public int? ImpegnoTot { get; set; }

    public string? Contatto { get; set; }
}

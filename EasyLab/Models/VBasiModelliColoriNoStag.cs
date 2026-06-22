using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiModelliColoriNoStag
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public byte[]? ContattoImg { get; set; }

    public int? IdStagLast { get; set; }

    public string? StagLast { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string? Nome { get; set; }

    public string CodCol { get; set; } = null!;

    public string? DescCol { get; set; }

    public int? Esiste { get; set; }

    public int? IdModLast { get; set; }

    public int? IdModColLast { get; set; }

    public string? StatoPv { get; set; }

    public string? CatMercMacro { get; set; }

    public string? CatMercMacro2 { get; set; }

    public string? CatMerc { get; set; }

    public string? CatMerc2 { get; set; }

    public string? DescMat { get; set; }

    public string? Nota { get; set; }

    public string? StatoPvDesc { get; set; }

    public int? StatoPvColore { get; set; }

    public string? IdStagElenco { get; set; }

    public string? StagElenco { get; set; }

    public int? IdStagionalita { get; set; }

    public string? StagionalitaCod { get; set; }

    public string? MatForn { get; set; }

    public string? MatComp { get; set; }

    public string? MatCodArtFornitore { get; set; }

    public string? MatDescComm { get; set; }

    public int? IdSet { get; set; }

    public int? IdModNoStag { get; set; }

    public string? DescCommerc { get; set; }

    public int? IdGender { get; set; }

    public string? GenderCod { get; set; }
}

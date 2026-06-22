using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VListino
{
    public string ProdMat { get; set; } = null!;

    public int? IdTipoList { get; set; }

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public string? CdTipoListino { get; set; }

    public string? TipoListDesc { get; set; }

    public string? CdValuta { get; set; }

    public string Stato { get; set; } = null!;

    public int IdStag { get; set; }

    public string? StagCod { get; set; }

    public string? StagDesc { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public string Mod { get; set; } = null!;

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public double? List { get; set; }

    public string? PathImgMod { get; set; }

    public string? TgDa { get; set; }

    public string? TgA { get; set; }

    public string? CatMercMacroCod { get; set; }

    public string? CatMercMacroDesc { get; set; }

    public string? Composizione { get; set; }

    public string? MadeIn { get; set; }

    public string? DescCommercMod { get; set; }

    public string? DescCommercTess { get; set; }

    public int? OrdPm { get; set; }

    public string? StatoMod { get; set; }

    public int? QtDa { get; set; }

    public int? QtA { get; set; }

    public DateOnly? ValidDa { get; set; }

    public DateOnly? ValidA { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? StatoExp { get; set; }

    public bool? CkAcq { get; set; }

    public int IdSetGroup { get; set; }

    public int? IdSet { get; set; }

    public DateTime? DataImp { get; set; }

    public DateTime? DataExp { get; set; }
}

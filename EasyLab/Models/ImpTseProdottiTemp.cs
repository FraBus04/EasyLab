using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpTseProdottiTemp
{
    public int Id { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string? Descrizione { get; set; }

    public string? Um { get; set; }

    public int? Stagione { get; set; }

    public string? MacroCategModello { get; set; }

    public string? CategoriaModello { get; set; }

    public string? MacroCategProdotto { get; set; }

    public string? CategoriaProdotto { get; set; }

    public string? RaggTaglia { get; set; }

    public string? Genere { get; set; }

    public string? StesoAppeso { get; set; }

    public string? MadeIn { get; set; }

    public string? OrigPreferenziale { get; set; }

    public string? KnittedWoven { get; set; }

    public string? Hscode { get; set; }

    public decimal? PesoN { get; set; }

    public string? Umpeso { get; set; }

    public string? Provenienza { get; set; }

    public string? Versione { get; set; }

    public int? CodiceLavaggio1 { get; set; }

    public int? CodiceLavaggio2 { get; set; }

    public int? CodiceLavaggio3 { get; set; }

    public int? CodiceLavaggio4 { get; set; }

    public int? CodiceLavaggio5 { get; set; }

    public int? CodiceLavaggio6 { get; set; }

    public bool? StatoInt { get; set; }

    public string? Stagionalita { get; set; }

    public string? Vestibilita { get; set; }

    public bool SyncEseguito { get; set; }

    public DateTime? SyncDataimport { get; set; }

    public DateTime? SyncDataexpcsv { get; set; }

    public int? SyncFlgeplm { get; set; }

    public int? IdMod { get; set; }

    public int? IdStag { get; set; }

    public int? IdNazione { get; set; }

    public string? Stato { get; set; }

    public DateTime? DataImp { get; set; }

    public int? IdGender { get; set; }

    public int? IdCatMerc { get; set; }

    public int? IdCatMercMacro { get; set; }

    public int? IdImballo { get; set; }

    public int? IdSet { get; set; }

    public int? IdTagliaDa { get; set; }

    public int? IdTagliaA { get; set; }

    public int? IdTagliaBase { get; set; }

    public int? IdKw { get; set; }

    public string? CdOp { get; set; }

    public int? Lav { get; set; }

    public DateTime? DataLav { get; set; }

    public string? Error { get; set; }

    public int? IdVest { get; set; }

    public int? IdStagionalita { get; set; }

    public int? SyncUniqueid { get; set; }

    public int? IdTesta { get; set; }

    public string? TagliaBase { get; set; }
}

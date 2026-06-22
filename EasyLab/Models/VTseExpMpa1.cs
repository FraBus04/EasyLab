using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VTseExpMpa1
{
    public int SyncUniqueid { get; set; }

    public string ModelloParte { get; set; } = null!;

    public string? Descrizione { get; set; }

    public string? Um { get; set; }

    public string? Stagione { get; set; }

    public string? MacroCategModello { get; set; }

    public string? CategoriaModello { get; set; }

    public string? MacroCategProdotto { get; set; }

    public string? CategoriaProdotto { get; set; }

    public string? RaggTaglia { get; set; }

    public string? TagliaBase { get; set; }

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

    public string? CodiceLavaggio1 { get; set; }

    public string? CodiceLavaggio2 { get; set; }

    public string? CodiceLavaggio3 { get; set; }

    public string? CodiceLavaggio4 { get; set; }

    public string? CodiceLavaggio5 { get; set; }

    public string? CodiceLavaggio6 { get; set; }

    public bool? Stato { get; set; }

    public string? Stagionalita { get; set; }

    public string? Vestibilita { get; set; }

    public bool SyncEseguito { get; set; }

    public DateTime? SyncDataimport { get; set; }

    public DateTime? SyncDataexpcsv { get; set; }

    public int? SyncFlgeplm { get; set; }

    public string? Stag { get; set; }

    public int? IdMod { get; set; }
}

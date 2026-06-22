using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class LauraCat
{
    public string? Stagione { get; set; }

    public string Status { get; set; } = null!;

    public string CodArtLink { get; set; } = null!;

    public string CodModParte { get; set; } = null!;

    public string Macrocategoria { get; set; } = null!;

    public string Categoria { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string ColorCode { get; set; } = null!;

    public string Colore { get; set; } = null!;

    public string DescrizioniBrevi { get; set; } = null!;

    public string? NomeLink { get; set; }

    public string? CatLink { get; set; }

    public string? MacroCatLink { get; set; }

    public int? IdMacroFamOld { get; set; }

    public int? IdFamOld { get; set; }

    public int? CkLink { get; set; }

    public int? IdFam { get; set; }

    public int? IdMacroFam { get; set; }

    public string? Sku { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }
}

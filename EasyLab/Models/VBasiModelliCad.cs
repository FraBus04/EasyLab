using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiModelliCad
{
    public string Stato { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public int IdStag { get; set; }

    public string? Stag { get; set; }

    public string Mod { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public int? IdSet { get; set; }

    public int? IdTagliaBase { get; set; }

    public short? IdTagliaDa { get; set; }

    public short? IdTagliaA { get; set; }

    public string? Tg { get; set; }

    public string TipoModello { get; set; } = null!;

    public string? Nota { get; set; }

    public string? PathImg { get; set; }

    public bool? CkModello { get; set; }

    public string? NotaCostruz { get; set; }

    public int? IdCatMerc { get; set; }

    public string? CatMerc { get; set; }

    public int? IdCatMercMacro { get; set; }

    public string? CatMercMacroCod { get; set; }

    public string? CatMercMacroDesc { get; set; }

    public string? CodSetTg { get; set; }

    public string? DescSetTg { get; set; }

    public string? BaseProv { get; set; }

    public string? Modellista { get; set; }

    public string? Umpeso { get; set; }

    public short? IdGender { get; set; }

    public string? Genere { get; set; }

    public int? IdModellista { get; set; }

    public int? IdVest { get; set; }

    public string? Vest { get; set; }

    public string? StatoApp { get; set; }

    public string? DescBreve { get; set; }

    public int? IdAvanzMod { get; set; }

    public string? AvanzMod { get; set; }
}

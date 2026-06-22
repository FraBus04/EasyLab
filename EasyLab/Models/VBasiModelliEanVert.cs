using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiModelliEanVert
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public string? StagCod { get; set; }

    public int IdMod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? Colore { get; set; }

    public string Taglia { get; set; } = null!;

    public int IdSetTagla { get; set; }

    public DateTime? DataCreaz { get; set; }

    public DateTime? DataLastModif { get; set; }

    public int? IdSet { get; set; }

    public string? Descrizione { get; set; }

    public string Stato { get; set; } = null!;

    public string Ean { get; set; } = null!;

    public string? DescCol { get; set; }

    public string? HsCode { get; set; }

    public string HsCodeDesc { get; set; } = null!;

    public string? Composizione { get; set; }

    public string? Kw { get; set; }

    public string? DescCommerc { get; set; }

    public string? MadeIn { get; set; }

    public string? MadeInDesc { get; set; }

    public short? Peso { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMerc { get; set; }

    public string? StatoMod { get; set; }

    public int? IdModCol { get; set; }

    public string? GenderCod { get; set; }

    public string? GenderDesc { get; set; }

    public string? StagDesc { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataExp { get; set; }

    public int? IdModColNoStag { get; set; }
}

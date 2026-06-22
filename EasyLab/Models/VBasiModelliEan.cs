using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiModelliEan
{
    public int Id { get; set; }

    public string? Cd { get; set; }

    public string Tipo { get; set; } = null!;

    public string Ean { get; set; } = null!;

    public string Stato { get; set; } = null!;

    public string? StatoMod { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModColNoStag { get; set; }

    public int IdSet { get; set; }

    public int IdSetTaglia { get; set; }

    public int IdSetOrd { get; set; }

    public string? StagCod { get; set; }

    public string? StagDesc { get; set; }

    public string? CdAll { get; set; }

    public string? CdAllcol { get; set; }

    public string? CdAllmis { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? ModCol { get; set; }

    public string Tg { get; set; } = null!;

    public string? Descrizione { get; set; }

    public string? DescCol { get; set; }

    public string? HsCode { get; set; }

    public string? Composizione { get; set; }

    public string? Kw { get; set; }

    public string? DescCommerc { get; set; }

    public string? MadeIn { get; set; }

    public string? MadeInDesc { get; set; }

    public short? Peso { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMerc { get; set; }

    public string? GenderCod { get; set; }

    public string? GenderDesc { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataExp { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdModNoStag { get; set; }

    public int IdSetGroup { get; set; }

    public string? Um { get; set; }

    public bool? Enab { get; set; }

    public int? CkExp { get; set; }
}

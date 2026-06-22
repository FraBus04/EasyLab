using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VbiListaEan
{
    public int? NrLista { get; set; }

    public string? NotaTesta { get; set; }

    public string Ean { get; set; } = null!;

    public string? StagCod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? Colore { get; set; }

    public string? DescCol { get; set; }

    public string? Taglia { get; set; }

    public int? IdModCol { get; set; }

    public int IdTesta { get; set; }

    public int Id { get; set; }
}

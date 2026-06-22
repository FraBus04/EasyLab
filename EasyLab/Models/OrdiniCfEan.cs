using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class OrdiniCfEan
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int? IdOrd { get; set; }

    public int? IdRiga { get; set; }

    public int IdMod { get; set; }

    public int IdModCol { get; set; }

    public int IdSet { get; set; }

    public int IdSetTaglia { get; set; }

    public string Taglia { get; set; } = null!;

    public string? Ean { get; set; }

    public int Nr { get; set; }

    public int? IdTipoListino1 { get; set; }

    public int? IdTipoListino2 { get; set; }

    public int? IdTipoListino3 { get; set; }

    public int? IdTipoListino4 { get; set; }

    public int? IdTipoListino5 { get; set; }

    public int? IdTipoListino6 { get; set; }

    public int? IdTipoListino7 { get; set; }

    public int? IdTipoListino8 { get; set; }

    public double? Listino1 { get; set; }

    public double? Listino2 { get; set; }

    public double? Listino3 { get; set; }

    public double? Listino4 { get; set; }

    public double? Listino5 { get; set; }

    public double? Listino6 { get; set; }

    public double? Listino7 { get; set; }

    public double? Listino8 { get; set; }

    public int? OrdTg { get; set; }
}

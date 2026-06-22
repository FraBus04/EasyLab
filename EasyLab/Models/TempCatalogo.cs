using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TempCatalogo
{
    public int Id { get; set; }

    public string? Path { get; set; }

    public string? Nota { get; set; }

    public int? IdCat { get; set; }

    public string? Nome { get; set; }

    public int? Ord { get; set; }

    public double? Listino { get; set; }

    public double? Listino2 { get; set; }
}

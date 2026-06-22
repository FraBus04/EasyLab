using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ListaEan
{
    public int Id { get; set; }

    public int? IdTesta { get; set; }

    public int IdUte { get; set; }

    public string Ean { get; set; } = null!;

    public DateTime DataIns { get; set; }

    public int IdEan { get; set; }

    public int? IdDoc { get; set; }

    public string? Epc { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ParteMi
{
    public int Id { get; set; }

    public int? IdUte { get; set; }

    public string? Cd { get; set; }

    public string? ParteMis { get; set; }

    public bool? Enab { get; set; }

    public int? Esiste { get; set; }

    public int? Pos { get; set; }

    public int? IdSetOrd { get; set; }
}

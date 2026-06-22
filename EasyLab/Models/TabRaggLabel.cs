using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabRaggLabel
{
    public int Id { get; set; }

    public int IdClasse { get; set; }

    public int Pos { get; set; }

    public string Descr { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Report
{
    public int Id { get; set; }

    public int IdClasse { get; set; }

    public string NomeReport { get; set; } = null!;

    public string? Descr { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Operazioni
{
    public int Id { get; set; }

    public string Operazione { get; set; } = null!;

    public string? DettOperazione { get; set; }

    public int? MisuraImg { get; set; }

    public string? PathImg { get; set; }

    public string? OperazAbbrev { get; set; }

    public string? Tipo { get; set; }
}

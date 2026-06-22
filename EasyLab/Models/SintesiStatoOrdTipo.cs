using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SintesiStatoOrdTipo
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int? Modo { get; set; }

    public string OrdTipo { get; set; } = null!;

    public int IdFase { get; set; }

    public int? TotCapi { get; set; }

    public double? TotVal { get; set; }

    public string? Color { get; set; }
}

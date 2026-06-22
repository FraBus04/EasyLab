using System;
using System.Collections.Generic;

namespace EasyLab.Models;

/// <summary>
/// Tab_Stato_Modello
/// Tab_Tipo_Modello
/// </summary>
public partial class SelSt
{
    public int IdClasse { get; set; }

    public int IdContatto { get; set; }

    public string Chiave { get; set; } = null!;

    public int IdUte { get; set; }

    public string? Cd { get; set; }

    public int? Id { get; set; }

    public DateOnly? Data { get; set; }

    public double? Val { get; set; }
}

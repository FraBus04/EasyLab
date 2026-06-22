using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SettingGrid
{
    public int Id { get; set; }

    public int IdUte { get; set; }

    public int IdClasse { get; set; }

    public string? Nome { get; set; }

    public int? Vista { get; set; }

    public string Controllo { get; set; } = null!;

    public string? StringaXml { get; set; }

    public DateTime? DataIns { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SettingGridViste
{
    public int Id { get; set; }

    public int IdUte { get; set; }

    public int IdForm { get; set; }

    public string NomeVista { get; set; } = null!;

    public string NomeGrid { get; set; } = null!;

    public string? StringaXml { get; set; }

    public DateTime? DataIns { get; set; }
}

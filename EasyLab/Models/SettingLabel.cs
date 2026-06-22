using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SettingLabel
{
    public int Id { get; set; }

    public string Controllo { get; set; } = null!;

    public string Ita { get; set; } = null!;

    public string? Eng { get; set; }

    public string? Esp { get; set; }
}

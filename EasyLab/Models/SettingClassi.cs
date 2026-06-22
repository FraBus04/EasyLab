using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SettingClassi
{
    public int Id { get; set; }

    public string Classe { get; set; } = null!;

    public string? DescBreve { get; set; }
}

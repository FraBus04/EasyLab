using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SettingSystemObj
{
    public int Id { get; set; }

    public int IdClasse { get; set; }

    public string Controllo { get; set; } = null!;

    public bool? VisDef { get; set; }

    public bool EnabDef { get; set; }

    public int? Visibility { get; set; }
}

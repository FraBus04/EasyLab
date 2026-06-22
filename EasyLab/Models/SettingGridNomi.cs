using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SettingGridNomi
{
    public int Id { get; set; }

    public int IdClasse { get; set; }

    public string Controllo { get; set; } = null!;

    public string? Nome { get; set; }
}

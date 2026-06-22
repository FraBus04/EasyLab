using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SettingAttributi
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdClasse { get; set; }

    public string Attributo { get; set; } = null!;

    public bool? CkFixedLen { get; set; }

    public short? FixedLen { get; set; }
}

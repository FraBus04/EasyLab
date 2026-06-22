using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiModelliNoStagTemp
{
    public int IdContatto { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public int? Esiste { get; set; }

    public int? IdUte { get; set; }
}

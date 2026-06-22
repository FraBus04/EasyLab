using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabFamigliaMateriale
{
    public int IdContatto { get; set; }

    public string CdFamMat { get; set; } = null!;

    public string? Descr { get; set; }

    public string MacroGruppo { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class LauraCatalogoFw24arrivi
{
    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string ModCol { get; set; } = null!;

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public DateOnly? DataPrimoCar { get; set; }

    public string? CdMag { get; set; }

    public DateOnly? DataUltimoCar { get; set; }
}

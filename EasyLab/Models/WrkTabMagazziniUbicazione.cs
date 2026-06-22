using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class WrkTabMagazziniUbicazione
{
    public int Id { get; set; }

    public string CodMag { get; set; } = null!;

    public short IdStag { get; set; }

    public short IdCcli { get; set; }

    public string? Descr { get; set; }
}

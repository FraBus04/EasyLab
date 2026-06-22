using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabTipoMateriale
{
    public int Id { get; set; }

    public string CdTipoMat { get; set; } = null!;

    public string? Descr { get; set; }

    public int? OrdPm { get; set; }

    public int? IdMpscar { get; set; }

    public double? Sfrido { get; set; }

    public bool? CkSfrido { get; set; }

    public bool? CkMp { get; set; }

    public bool? CkMrp { get; set; }

    public bool? CkFabb { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public bool? CkAbbModello { get; set; }

    public string? Um { get; set; }

    public string? Tp { get; set; }

    public bool? CkMatTaglio { get; set; }

    public string? CdMag { get; set; }
}

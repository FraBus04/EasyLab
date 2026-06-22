using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MagazzinoCfCkN001
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdSet { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? IdSetOrd { get; set; }

    public int IdEan { get; set; }

    public string? Ean { get; set; }

    public string CdMag { get; set; } = null!;

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string ModCol { get; set; } = null!;

    public string Tg { get; set; } = null!;

    public int? Nr { get; set; }

    public int? ImpegnoTot { get; set; }

    public int? MagAss { get; set; }

    public int? MagDaAss { get; set; }

    public int? MagDispDaAss { get; set; }

    public int? MagDisp { get; set; }

    public int? NrDispDaAss { get; set; }

    public int? NrDispStock { get; set; }

    public int Car { get; set; }

    public int Sca { get; set; }

    public int Ord { get; set; }

    public DateTime Ts { get; set; }

    public string? RefContatto { get; set; }

    public int? IdCatMerc { get; set; }

    public DateTime? DataImp { get; set; }

    public DateTime? DataExp { get; set; }

    public string? StatoExp { get; set; }

    public int? Mag { get; set; }

    public int? Libero { get; set; }
}

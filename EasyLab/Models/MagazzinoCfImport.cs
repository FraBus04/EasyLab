using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MagazzinoCfImport
{
    public int Id { get; set; }

    public int IdEan { get; set; }

    public int IdContatto { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdSet { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? IdSetOrd { get; set; }

    public string CdMag { get; set; } = null!;

    public string? Ean { get; set; }

    public string? Stag { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string ModCol { get; set; } = null!;

    public string? Tg { get; set; }

    public int? Nr { get; set; }

    public int? Car { get; set; }

    public int? Sca { get; set; }

    public int? Ord { get; set; }

    public DateTime Ts { get; set; }

    public string? RefContatto { get; set; }

    public int? IdCatMerc { get; set; }

    public string? CdCatMercImp { get; set; }

    public string? CdCatMercImp2 { get; set; }

    public string? Anno { get; set; }

    public int? IdSetImp { get; set; }

    public int? IdTagliaImp { get; set; }

    public int? IdTagliaOrdImp { get; set; }

    public string? TagliaImp { get; set; }

    public string? StagMas { get; set; }

    public string? AnnoMas { get; set; }

    public int? ImpegnoTot { get; set; }

    public int? MagAss { get; set; }

    public int? MagDisp { get; set; }

    public int? MagDaAss { get; set; }

    public int? MagDispDaAss { get; set; }

    public int? BpdaPrel { get; set; }
}

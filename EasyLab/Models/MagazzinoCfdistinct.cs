using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MagazzinoCfdistinct
{
    public int Id { get; set; }

    public int IdUte { get; set; }

    public int? IdClasse { get; set; }

    public int? EanKey { get; set; }

    public int IdContatto { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdSet { get; set; }

    public int? IdCatMerc { get; set; }

    public int? IdCatMerc2 { get; set; }

    public int? IdCatMercMacro { get; set; }

    public int? IdCatMercMacro2 { get; set; }

    public int? IdStagionalita { get; set; }

    public string? StatoPv { get; set; }

    public string? CdMag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ModCol { get; set; }

    public bool? CkModCol { get; set; }

    public bool? CkAccorpaMag { get; set; }

    public int? Nr { get; set; }

    public int? Negativi { get; set; }

    public int? MagAss { get; set; }

    public int? MagDaAss { get; set; }

    public int? MagDispDaAss { get; set; }

    public int? MagDisp { get; set; }

    public DateTime? DataIns { get; set; }

    public int? ImpegnoTot { get; set; }
}

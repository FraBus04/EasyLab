using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BiCalcoloValMagazzinoMp
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public DateOnly DataDa { get; set; }

    public DateOnly? DataA { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public decimal Pz { get; set; }

    public double? QtCar { get; set; }

    public double? QtScr { get; set; }

    public decimal? ValCar { get; set; }

    public decimal? ValScr { get; set; }

    public int? IdUte { get; set; }

    public double? QtMag { get; set; }

    public decimal? ValMag { get; set; }

    public string? TipoMpScar { get; set; }
}

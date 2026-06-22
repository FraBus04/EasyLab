using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BiCalcoloValMagazzinoCf
{
    public int Id { get; set; }

    public int? IdEan { get; set; }

    public int? IdContatto { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? IdSetGroup { get; set; }

    public int? QtaCar { get; set; }

    public int? QtaScr { get; set; }

    public int? QtaSaldo { get; set; }

    public DateOnly? DataA { get; set; }

    public int? IdTipoList { get; set; }

    public decimal? ValUn { get; set; }

    public decimal? ValTot { get; set; }

    public string? CdMag { get; set; }

    public int? IdUte { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpOrdiniPfdetailTemp
{
    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ModCol { get; set; }

    public string? Tg { get; set; }

    public short? Nr { get; set; }

    public decimal? PzArt { get; set; }

    public int Id { get; set; }

    public int? IdContatto { get; set; }

    public int? IdOrd { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdSet { get; set; }

    public int? IdSetTg { get; set; }

    public int? IdSetGroup { get; set; }
}

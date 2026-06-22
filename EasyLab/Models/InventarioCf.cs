using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class InventarioCf
{
    public int Id { get; set; }

    public int? IdContatto { get; set; }

    public string? CdMag { get; set; }

    public int IdEan { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdSet { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? IdSetOrd { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ModCol { get; set; }

    public string? Tg { get; set; }

    public string Ean { get; set; } = null!;

    public int? Invent { get; set; }

    public int? Mag { get; set; }

    public int? Diff { get; set; }

    public string? SetDesc { get; set; }

    public DateTime DataIns { get; set; }

    public int IdUteIns { get; set; }

    public string? Contatto { get; set; }
}

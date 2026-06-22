using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class CheckBarcode
{
    public int Id { get; set; }

    public string Ean { get; set; } = null!;

    public string Stato { get; set; } = null!;

    public int IdStag { get; set; }

    public int IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public int IdSet { get; set; }

    public int IdSetTaglia { get; set; }

    public int IdSetGroup { get; set; }

    public int IdSetOrd { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ModCol { get; set; }

    public string Tg { get; set; } = null!;

    public int? CkExp { get; set; }

    public DateTime? DataExp { get; set; }

    public string? StatoExp { get; set; }

    public int? CkEsisteTws { get; set; }

    public int? ModColCountPlm { get; set; }

    public int? ModColCountTws { get; set; }

    public int? ModColCountTse { get; set; }

    public int? ModColCountTse2 { get; set; }
}

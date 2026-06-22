using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzSpedPklEpc
{
    public int Id { get; set; }

    public int IdPkltesta { get; set; }

    public int IdPklbox { get; set; }

    public int IdEan { get; set; }

    public string Epc { get; set; } = null!;

    public DateTime DataIns { get; set; }

    public int IdUteIns { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdSet { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? IdSetGroup { get; set; }

    public int? IdSetOrd { get; set; }

    public int? IdRigaOrd { get; set; }

    public long? IdEpc { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ModCol { get; set; }

    public string? Tg { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }
}

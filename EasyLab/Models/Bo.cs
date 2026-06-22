using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Bo
{
    public string CodiceArticolo { get; set; } = null!;

    public string? Alias { get; set; }

    public string Variante { get; set; } = null!;

    public string Descrizione { get; set; } = null!;

    public string Um1 { get; set; } = null!;

    public string Dep { get; set; } = null!;

    public byte GiacFisc1 { get; set; }

    public string? Ean { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdSet { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? IdSetOrd { get; set; }

    public int? IdEan { get; set; }
}

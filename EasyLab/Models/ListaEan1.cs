using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ListaEan1
{
    public string? Nome { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ModCol { get; set; }

    public string? Tg { get; set; }

    public int Id { get; set; }

    public int? IdContatto { get; set; }

    public int? IdDoc { get; set; }

    public int? IdUte { get; set; }

    public string? Ean { get; set; }

    public DateTime? DataIns { get; set; }

    public int? IdEan { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdSet { get; set; }

    public bool? CkErr { get; set; }
}

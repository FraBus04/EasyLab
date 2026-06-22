using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Svenditum
{
    public int Id { get; set; }

    public string? CodiceArticolo { get; set; }

    public string? Variante { get; set; }

    public string? Descrizione { get; set; }

    public string? Um1 { get; set; }

    public double GiacFisc1 { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdStag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public bool? CkFatto { get; set; }

    public int? IdModNew { get; set; }

    public int? IdModColNew { get; set; }

    public int? IdEan { get; set; }

    public string? Ean { get; set; }

    public int? IdStagNew { get; set; }
}

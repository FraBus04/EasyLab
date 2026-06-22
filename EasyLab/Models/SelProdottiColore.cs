using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SelProdottiColore
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdUtente { get; set; }

    public int? IdMod { get; set; }

    public string? CodCol { get; set; }

    public int? IdStag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public DateTime? Ts { get; set; }

    public string? Nome { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModColNoStag { get; set; }
}

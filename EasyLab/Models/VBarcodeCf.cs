using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBarcodeCf
{
    public int? IdContatto { get; set; }

    public int? IdStag { get; set; }

    public string? Ean { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string Taglia { get; set; } = null!;

    public int? IdSet { get; set; }

    public int IdSetTagla { get; set; }

    public string? Nome { get; set; }

    public string? Col { get; set; }

    public string? DescCol { get; set; }

    public string? Stag { get; set; }

    public string? PathImgMod { get; set; }

    public string? PathImgColore { get; set; }

    public int Id { get; set; }

    public int? IdMdlold { get; set; }

    public int? CkExp { get; set; }

    public DateTime? LastExp { get; set; }

    public string? Nota1 { get; set; }
}

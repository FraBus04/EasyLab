using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VMagazzinoCfVertDispTrasf
{
    public int Id { get; set; }

    public int IdBarcode { get; set; }

    public string? Ean13 { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModColNoStag { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string? Nome { get; set; }

    public string CodCol { get; set; } = null!;

    public string? IdSet { get; set; }

    public int? IdTaglia { get; set; }

    public int? IdTagliaOrd { get; set; }

    public string Taglia { get; set; } = null!;

    public string? CodMagDa { get; set; }

    public int? Nr1 { get; set; }

    public string? CodMagA { get; set; }
}

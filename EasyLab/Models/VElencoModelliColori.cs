using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VElencoModelliColori
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public int IdMod { get; set; }

    public string CodCol { get; set; } = null!;

    public string? DescCol { get; set; }

    public int? OrdPm { get; set; }

    public string? PathImg { get; set; }

    public int? IdStag { get; set; }

    public int? IdContatto { get; set; }

    public bool Enabled { get; set; }

    public int? IdModColNoStag { get; set; }
}

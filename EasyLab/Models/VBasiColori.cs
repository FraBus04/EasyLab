using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiColori
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string? Contatti { get; set; }

    public string? Cartella { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public string CodCol { get; set; } = null!;

    public string? DescCol { get; set; }

    public string? PathImg { get; set; }
}

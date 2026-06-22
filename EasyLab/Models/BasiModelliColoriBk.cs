using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiModelliColoriBk
{
    public int Id { get; set; }

    public int IdMod { get; set; }

    public string CodCol { get; set; } = null!;

    public string? DescCol { get; set; }

    public string? DescColVb6 { get; set; }

    public int? OrdPm { get; set; }

    public int? IdPathLav { get; set; }

    public string? PathImg { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public bool Enabled { get; set; }

    public int? IdModColNoStag { get; set; }
}

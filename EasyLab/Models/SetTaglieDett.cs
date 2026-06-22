using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SetTaglieDett
{
    public int Id { get; set; }

    public int IdSetTaglie { get; set; }

    public string Tg { get; set; } = null!;

    public int? Ord { get; set; }

    public string? TgCli { get; set; }

    public int? IdSetCli { get; set; }

    public int? IdMatMis { get; set; }

    public int? IdSetGroup { get; set; }

    public bool? CkCosto { get; set; }
}

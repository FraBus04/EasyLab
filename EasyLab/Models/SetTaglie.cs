using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SetTaglie
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public string? Cod { get; set; }

    public string? Descr { get; set; }

    public short? CodOld { get; set; }

    public int? IdSetCli { get; set; }

    public string? CdSetCli { get; set; }

    public bool? CkTgCli { get; set; }

    public int? IdTagliaBase { get; set; }

    public int? IdTagliaDa { get; set; }

    public int? IdTagliaA { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VModelloColore1
{
    public int Id { get; set; }

    public short IdStag { get; set; }

    public short IdCcli { get; set; }

    public int? IdContatto { get; set; }

    public string? Ean { get; set; }

    public int? IdMdl { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public string Taglia { get; set; } = null!;

    public int? IdSet { get; set; }

    public int IdTaglia { get; set; }

    public string? Stato { get; set; }

    public int? IdTagliaOrd { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModColNoStag { get; set; }
}

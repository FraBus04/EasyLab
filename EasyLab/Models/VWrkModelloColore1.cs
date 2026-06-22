using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VWrkModelloColore1
{
    public int Id { get; set; }

    public short IdStag { get; set; }

    public short IdCcli { get; set; }

    public int? IdMdl { get; set; }

    public int? IdModCol { get; set; }

    public string? Ean { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string Taglia { get; set; } = null!;

    public int IdSetTagla { get; set; }

    public int? IdSet { get; set; }

    public string? Stato { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? OrdTg { get; set; }

    public string? Colore { get; set; }

    public int? IdContatto { get; set; }
}

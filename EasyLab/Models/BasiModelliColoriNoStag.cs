using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiModelliColoriNoStag
{
    public int Id { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string CodCol { get; set; } = null!;

    public int IdContatto { get; set; }

    public int? Esiste { get; set; }

    public int? IdStagLast { get; set; }

    public int? IdModLast { get; set; }

    public int? IdModColLast { get; set; }

    public string? StatoPv { get; set; }

    public string? IdStagElenco { get; set; }

    public string? StagElenco { get; set; }

    public string? PathImg { get; set; }

    public int? IdModNoStag { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

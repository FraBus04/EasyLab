using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class LineSheetRufw23
{
    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string MacroCategoria { get; set; } = null!;

    public string Categoria { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string CodCol { get; set; } = null!;

    public string DescCol { get; set; } = null!;

    public string? EngShortDesc { get; set; }

    public string SelezioneXRussia { get; set; } = null!;

    public short? Ss23RetPr { get; set; }

    public short Fw23RePricingLaura { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdStag { get; set; }

    public int? IdModColNoStag { get; set; }
}

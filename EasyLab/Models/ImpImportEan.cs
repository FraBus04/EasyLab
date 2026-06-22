using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpImportEan
{
    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ModCol { get; set; }

    public string? Tg { get; set; }

    public string? Ean { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdSet { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? IdSetOrd { get; set; }

    public int? CkErr { get; set; }

    public int Id { get; set; }

    public string? Eanesistente { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdStagMod { get; set; }

    public bool? CkEanUguale { get; set; }

    public string? StagMod { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class AnagBestStoreBk
{
    public int Id { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public int? Scal { get; set; }

    public string? CdMacroCatMerc { get; set; }

    public string? CdCatMerc { get; set; }

    public string? StagCode { get; set; }

    public string? Anno { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdSetPdm { get; set; }

    public string? Composition { get; set; }

    public string? StagCodeRic { get; set; }

    public string? AnnoRic { get; set; }

    public int? IdCodColNoStag { get; set; }
}

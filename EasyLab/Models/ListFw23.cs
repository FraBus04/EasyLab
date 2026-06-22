using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ListFw23
{
    public string ArtTex { get; set; } = null!;

    public string Artcode { get; set; } = null!;

    public string Texcode { get; set; } = null!;

    public string Colorcode { get; set; } = null!;

    public string Colorname { get; set; } = null!;

    public short Whl { get; set; }

    public short Rtl { get; set; }

    public short RtlChf095 { get; set; }

    public short RtlGbp089 { get; set; }

    public short Usd { get; set; }

    public bool? UsSelection { get; set; }

    public double? TseretUsd { get; set; }

    public double? TseretChf { get; set; }

    public double? TseretGbp { get; set; }
}

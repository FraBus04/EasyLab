using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpDocMp
{
    public string? Mat { get; set; }

    public string? MatCol { get; set; }

    public string? MatMis { get; set; }

    public double? Qta { get; set; }

    public double? Prz { get; set; }

    public int Id { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public string? DescMat { get; set; }

    public bool? CkMatMis { get; set; }

    public bool? CkErr { get; set; }
}

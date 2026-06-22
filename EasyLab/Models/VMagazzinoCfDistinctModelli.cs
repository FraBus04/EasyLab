using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VMagazzinoCfDistinctModelli
{
    public int IdContatto { get; set; }

    public int? IdStag { get; set; }

    public string CdMag { get; set; } = null!;

    public string? CodMagDesc { get; set; }

    public int? IdMod { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public int? IdSet { get; set; }

    public DateTime Ts { get; set; }

    public int? TotCapi { get; set; }

    public string? Nome { get; set; }

    public string? LinCod { get; set; }

    public string? LinDesc { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public int? CatMercId { get; set; }

    public int? IdLinea { get; set; }

    public string? StagCod { get; set; }

    public string? StagDesc { get; set; }

    public short? IdGender { get; set; }

    public string? GenderCod { get; set; }

    public string? GenderDesc { get; set; }

    public string? PathImgMod { get; set; }

    public string? MadeIn { get; set; }

    public string? MadeInDesc { get; set; }

    public string? Composizione { get; set; }

    public string? Lav1 { get; set; }

    public string? Lav2 { get; set; }

    public string? Lav3 { get; set; }

    public string? Lav4 { get; set; }

    public string? Lav5 { get; set; }

    public string? Lav6 { get; set; }

    public int IdModColNoStag { get; set; }
}

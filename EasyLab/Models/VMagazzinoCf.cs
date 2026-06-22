using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VMagazzinoCf
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdSet { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? IdSetOrd { get; set; }

    public int IdEan { get; set; }

    public int? IdLinea { get; set; }

    public string CdMag { get; set; } = null!;

    public string? MagDesc { get; set; }

    public string? StagCod { get; set; }

    public string? StagDesc { get; set; }

    public string? Linea { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string? Nome { get; set; }

    public string ModCol { get; set; } = null!;

    public string? DescCol { get; set; }

    public string Tg { get; set; } = null!;

    public string? Ean { get; set; }

    public int? Nr { get; set; }

    public int Car { get; set; }

    public int Sca { get; set; }

    public int? MagDaAss { get; set; }

    public int? MagDispDaAss { get; set; }

    public int? MagAss { get; set; }

    public int? MagDisp { get; set; }

    public DateTime Ts { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public string? Composizione { get; set; }

    public string? MadeIn { get; set; }

    public string? MadeInDesc { get; set; }

    public short? Peso { get; set; }

    public int? IdCatMerc { get; set; }

    public int? IdCatMerc2 { get; set; }

    public int? IdCatMercMacro { get; set; }

    public int? IdCatMercMacro2 { get; set; }

    public int? IdStagionalita { get; set; }

    public string? Contatto { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VMagazzinoCfVert
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int? IdStag { get; set; }

    public string? StagCod { get; set; }

    public string? StagDesc { get; set; }

    public string CodMag { get; set; } = null!;

    public string? MagDesc { get; set; }

    public int? IdLinea { get; set; }

    public string? Linea { get; set; }

    public int? IdMod { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string? Nome { get; set; }

    public string CodCol { get; set; } = null!;

    public string? DescCol { get; set; }

    public string? IdSet { get; set; }

    public int? IdTaglia { get; set; }

    public int? IdTagliaOrd { get; set; }

    public string Tagla { get; set; } = null!;

    public int IdBarcode { get; set; }

    public string? Ean { get; set; }

    public short? Nr { get; set; }

    public int Car { get; set; }

    public int Sca { get; set; }

    public int? MagDaAss { get; set; }

    public int? MagDispDaAss { get; set; }

    public int? MagAss { get; set; }

    public int? MagDisp { get; set; }

    public int Ord { get; set; }

    public DateTime Ts { get; set; }

    public string? RefContatto { get; set; }

    public string? PathImgMod { get; set; }

    public string? PathImgCol { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public string? Composizione { get; set; }

    public string? MadeIn { get; set; }

    public string? MadeInDesc { get; set; }

    public short? Peso { get; set; }

    public string? Tipo { get; set; }

    public string? StatoMag { get; set; }

    public int? IdModColNoStag { get; set; }
}

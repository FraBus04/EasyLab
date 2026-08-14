using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MagazzinoMpDettaglioRiga
{
    public int Id { get; set; }

    public string? CdMat { get; set; }

    public string Lotto { get; set; } = null!;

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public string? Mis { get; set; }

    public string? DescMis { get; set; }

    public string NrPezza { get; set; } = null!;

    public DateTime? DataIng { get; set; }

    public decimal? Qta { get; set; }

    public string? Scaffale { get; set; }

    public string? Posizione { get; set; }

    public string? Piano { get; set; }

    public string? MagLogico { get; set; }

    public string CdMag { get; set; } = null!;

    public string? CdCella { get; set; }

    public bool? Bloccato { get; set; }

    public bool? Disponibile { get; set; }

    public string? DescMat { get; set; }

    public string? Forn { get; set; }

    public string? CodColForn { get; set; }

    public string? PathImgMat { get; set; }

    public string? PathImgCol { get; set; }

    public int IdContatto { get; set; }
}

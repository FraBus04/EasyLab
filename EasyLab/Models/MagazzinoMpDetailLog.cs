using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MagazzinoMpDetailLog
{
    public int Id { get; set; }

    public string? CdMat { get; set; }

    public string? Lotto { get; set; }

    public string? CodCol { get; set; }

    public string? Mis { get; set; }

    public string? NrPezza { get; set; }

    public DateTime? DataIng { get; set; }

    public double? Qta { get; set; }

    public string? Scaffale { get; set; }

    public string? Posizione { get; set; }

    public string? Piano { get; set; }

    public string? MagLogico { get; set; }

    public string? CdMag { get; set; }

    public string? CdCella { get; set; }

    public bool? Bloccato { get; set; }

    public bool? Disponibile { get; set; }

    public int IdContatto { get; set; }

    public DateTime? Ts { get; set; }

    public string? Gest { get; set; }
}

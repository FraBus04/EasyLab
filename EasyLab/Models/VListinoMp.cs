using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VListinoMp
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdContatto { get; set; }

    public int IdTipoList { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public decimal? List { get; set; }

    public int? QtDa { get; set; }

    public int? QtA { get; set; }

    public DateOnly? ValidDa { get; set; }

    public DateOnly? ValidA { get; set; }

    public string? TipoCalcolo { get; set; }

    public string? Mat { get; set; }

    public string? DescMat { get; set; }

    public string? Tp { get; set; }

    public string? Fornitore { get; set; }

    public string? MatCol { get; set; }

    public string? MatColDesc { get; set; }

    public string? MatMis { get; set; }

    public string? MatMisDesc { get; set; }

    public string? CodArtFornitore { get; set; }

    public bool? CkMatMis { get; set; }
}

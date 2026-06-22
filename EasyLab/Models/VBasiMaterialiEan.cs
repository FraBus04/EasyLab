using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiMaterialiEan
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public int IdContatto { get; set; }

    public string? CdAll { get; set; }

    public string? CdAllcol { get; set; }

    public string? CdAllmis { get; set; }

    public string? CdEan { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public string Mat { get; set; } = null!;

    public string MatCol { get; set; } = null!;

    public string MatMis { get; set; } = null!;

    public string MatColMis { get; set; } = null!;

    public string MatColMisDesc { get; set; } = null!;

    public string? Um { get; set; }

    public string DescMat { get; set; } = null!;

    public string? DescCol { get; set; }

    public string DescMis { get; set; } = null!;

    public string CodArtFornitore { get; set; } = null!;

    public string? Forn { get; set; }

    public bool EnabMis { get; set; }

    public bool EnabCol { get; set; }

    public bool CkMatMis { get; set; }

    public string? Contatto { get; set; }

    public string? IdEanstr { get; set; }
}

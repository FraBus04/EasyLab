using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiMaterialiEan2
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public string? Cd { get; set; }

    public string? CdAll { get; set; }

    public string? CdAllcol { get; set; }

    public string? CdAllmis { get; set; }

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? Parte { get; set; }

    public string? ParteDesc { get; set; }

    public string? ParteCol { get; set; }

    public string? ParteColDesc { get; set; }

    public string ParteMis { get; set; } = null!;

    public string ParteMisDesc { get; set; } = null!;

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public bool CkMatMis { get; set; }

    public string? Um { get; set; }

    public string? Stag { get; set; }
}

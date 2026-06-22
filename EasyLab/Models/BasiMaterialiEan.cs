using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiMaterialiEan
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public bool CkMatMis { get; set; }

    public DateTime? DataIns { get; set; }

    public string? Tipo { get; set; }

    public string? Cd { get; set; }

    public string? CdAll { get; set; }

    public string? CdAllcol { get; set; }

    public string? CdAllmis { get; set; }
}

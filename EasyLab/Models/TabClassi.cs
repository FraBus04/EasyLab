using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabClassi
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public string Classe { get; set; } = null!;

    public string? ClasseObj { get; set; }

    public string DescBreve { get; set; } = null!;

    public int? IdPadre { get; set; }

    public bool CkidClasseDoc { get; set; }

    public bool CkVis { get; set; }

    public bool CkUpd { get; set; }

    public bool? CkIns { get; set; }

    public string? Alias { get; set; }
}

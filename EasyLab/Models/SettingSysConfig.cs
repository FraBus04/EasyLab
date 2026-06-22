using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SettingSysConfig
{
    public int Id { get; set; }

    public bool? CkUtilizzo { get; set; }

    public int IdClasse { get; set; }

    public int IdUte { get; set; }

    public int IdUteGru { get; set; }

    public string? CtrlType { get; set; }

    public string CtrlName { get; set; } = null!;

    public string? Caption { get; set; }

    public string Lab { get; set; } = null!;

    public int CkVis { get; set; }

    public bool CkEnab { get; set; }
}

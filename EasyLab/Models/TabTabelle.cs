using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabTabelle
{
    public string Tab { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public string Form { get; set; } = null!;

    public bool CkVis { get; set; }

    public bool CkEnab { get; set; }
}

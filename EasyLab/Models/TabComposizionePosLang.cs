using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabComposizionePosLang
{
    public int IdPos { get; set; }

    public int IdLingua { get; set; }

    public string Descr { get; set; } = null!;
}

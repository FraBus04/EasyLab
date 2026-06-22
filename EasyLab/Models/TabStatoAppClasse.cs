using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabStatoAppClasse
{
    public int IdClasse { get; set; }

    public int IdSottoClasse { get; set; }

    public string StatoApp { get; set; } = null!;

    public string Descr { get; set; } = null!;

    public int OrdPm { get; set; }
}

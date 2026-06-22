using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabCatMerceologicaLang
{
    public int Id { get; set; }

    public int IdLingua { get; set; }

    public string Descr { get; set; } = null!;
}

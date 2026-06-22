using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabSimboliLavLang
{
    public int IdPos { get; set; }

    public int IdLingua { get; set; }

    public string Descr { get; set; } = null!;

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

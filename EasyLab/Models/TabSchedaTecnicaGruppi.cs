using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabSchedaTecnicaGruppi
{
    public int IdGruppo { get; set; }

    public int IdContatto { get; set; }

    public string Descr { get; set; } = null!;

    public int? Livello { get; set; }

    public bool? CkRich { get; set; }

    public byte[]? Img { get; set; }
}

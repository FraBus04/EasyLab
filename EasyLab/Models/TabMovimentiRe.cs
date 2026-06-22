using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabMovimentiRe
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string Cod { get; set; } = null!;

    public string Descr { get; set; } = null!;

    public string CodMag { get; set; } = null!;

    public bool MovOpp { get; set; }

    public int IdCausale { get; set; }

    public int? IdTipoMov { get; set; }
}

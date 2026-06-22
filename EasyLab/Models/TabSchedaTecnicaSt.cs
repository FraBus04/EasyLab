using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabSchedaTecnicaSt
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdGruppo { get; set; }

    public string Nome { get; set; } = null!;

    public int IdSt { get; set; }

    public int? OrdPm { get; set; }
}

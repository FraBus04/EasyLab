using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiBulletPoint
{
    public int Id { get; set; }

    public int IdClasse { get; set; }

    public int IdRif { get; set; }

    public int IdTabBp { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

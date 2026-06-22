using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabAvanzModelloCp
{
    public int Id { get; set; }

    public int IdAvanzModCftesta { get; set; }

    public int IdAvanzMod { get; set; }

    public int OrdPm { get; set; }

    public int DayAvanz { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

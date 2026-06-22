using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabAvanzModelloCptestum
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdCatMerc { get; set; }

    public string? Descr { get; set; }

    public int? OrdPm { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

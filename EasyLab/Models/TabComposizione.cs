using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabComposizione
{
    public int Id { get; set; }

    public int? IdContatto { get; set; }

    public string? Composizione { get; set; }

    public int? IdFibraPrev { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? CdImp { get; set; }

    public string? Nota { get; set; }

    public string? CompEstesa { get; set; }

    public string? Stato { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataExp { get; set; }
}

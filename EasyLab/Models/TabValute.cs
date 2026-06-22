using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabValute
{
    public int Id { get; set; }

    public string? Stato { get; set; }

    public string? CdValuta { get; set; }

    public string? Desc { get; set; }

    public decimal? Cambio { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteUpd { get; set; }

    public decimal? CambioValutaEuro { get; set; }
}

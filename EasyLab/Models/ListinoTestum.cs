using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ListinoTestum
{
    public int Id { get; set; }

    public int IdTipoList { get; set; }

    public int IdContatto { get; set; }

    public string? Descr { get; set; }

    public DateOnly? ValidDa { get; set; }

    public DateOnly? ValidA { get; set; }

    public string? CdValuta { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

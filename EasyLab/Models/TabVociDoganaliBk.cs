using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabVociDoganaliBk
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string Cod { get; set; } = null!;

    public string? Nota { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? Tipo { get; set; }
}

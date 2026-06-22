using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiModelliEanEpcLog
{
    public long Id { get; set; }

    public int? IdLista { get; set; }

    public int? IdDoc { get; set; }

    public string Epc { get; set; } = null!;
}

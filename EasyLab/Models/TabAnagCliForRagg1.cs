using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabAnagCliForRagg1
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string Cod { get; set; } = null!;

    public string? Descr { get; set; }

    public int? OrdPm { get; set; }
}

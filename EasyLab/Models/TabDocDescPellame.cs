using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabDocDescPellame
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string Descr { get; set; } = null!;
}

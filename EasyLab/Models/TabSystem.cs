using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabSystem
{
    public string CodTab { get; set; } = null!;

    public int Id { get; set; }

    public string? Cod { get; set; }

    public string Descr { get; set; } = null!;
}

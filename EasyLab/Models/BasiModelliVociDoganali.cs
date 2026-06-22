using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiModelliVociDoganali
{
    public int Id { get; set; }

    public int IdMod { get; set; }

    public int IdNazione { get; set; }

    public string VociDoganali { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SelTabMagazziniClassi
{
    public int IdClasse { get; set; }

    public int IdUte { get; set; }

    public string CodMag { get; set; } = null!;
}

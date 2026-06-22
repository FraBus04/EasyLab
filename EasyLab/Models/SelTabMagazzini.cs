using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SelTabMagazzini
{
    public int IdContatto { get; set; }

    public int IdUte { get; set; }

    public string CodMag { get; set; } = null!;
}

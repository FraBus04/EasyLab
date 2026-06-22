using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SelMagazzinoCf
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdUte { get; set; }

    public int IdMod { get; set; }

    public int? IdModCol { get; set; }

    public string CodMag { get; set; } = null!;
}

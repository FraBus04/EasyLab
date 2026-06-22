using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SelMagazziniClassi
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdClasse { get; set; }

    public int IdUte { get; set; }

    public string CodMag { get; set; } = null!;
}

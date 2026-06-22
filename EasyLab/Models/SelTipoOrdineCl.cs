using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SelTipoOrdineCl
{
    public int IdContatto { get; set; }

    public int IdUte { get; set; }

    public string OrdTipo { get; set; } = null!;
}

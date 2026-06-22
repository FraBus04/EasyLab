using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SelTipoMaterialiPianif
{
    public int IdContatto { get; set; }

    public int IdUte { get; set; }

    public string CdTipoMat { get; set; } = null!;
}

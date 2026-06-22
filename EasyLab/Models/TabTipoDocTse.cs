using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabTipoDocTse
{
    public string Cod { get; set; } = null!;

    public string Descr { get; set; } = null!;

    public bool? CkMovImp { get; set; }

    public bool? CkVendita { get; set; }
}

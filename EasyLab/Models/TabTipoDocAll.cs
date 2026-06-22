using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabTipoDocAll
{
    public string CdCanale { get; set; } = null!;

    public string Cod { get; set; } = null!;

    public string Descr { get; set; } = null!;

    public bool? CkMovImp { get; set; }

    public string Segno { get; set; } = null!;

    public bool? CkRetail { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabTipoMov
{
    public int Id { get; set; }

    public int IdClasseDoc { get; set; }

    public int IdCausale { get; set; }

    public string Cod { get; set; } = null!;

    public string Descr { get; set; } = null!;

    public string? CodMag { get; set; }

    public bool CkNrPezzaFiglia { get; set; }

    public bool? CkRetInvPos { get; set; }

    public bool? CkRetInvNeg { get; set; }
}

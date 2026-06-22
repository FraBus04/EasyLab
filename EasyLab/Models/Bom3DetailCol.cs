using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Bom3DetailCol
{
    public int Id { get; set; }

    public int IdRigaReticolo { get; set; }

    public int AIdContatto { get; set; }

    public int AIdStag { get; set; }

    public string ACdAll { get; set; } = null!;

    public string ACdAllcol { get; set; } = null!;

    public int Ver { get; set; }

    public string BCdAll { get; set; } = null!;

    public string BCdAllcol { get; set; } = null!;

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? IdRigaOld { get; set; }

    public string? ACdAllcolOld { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Bom3ReticoloSchedum
{
    public int IdRigaReticolo { get; set; }

    public string? RichText { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }
}

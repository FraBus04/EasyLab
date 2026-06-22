using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Bom3DetailMi
{
    public int Id { get; set; }

    public int IdRigaReticolo { get; set; }

    public int AIdContatto { get; set; }

    public int AIdStag { get; set; }

    public string ACdAll { get; set; } = null!;

    public string ACdAllmis { get; set; } = null!;

    public int Ver { get; set; }

    public string BCdAll { get; set; } = null!;

    public string BCdAllmis { get; set; } = null!;

    public double? Cons { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? IdRigaOld { get; set; }

    public int? IdSetOrd { get; set; }
}

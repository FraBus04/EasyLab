using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzBuonoPrelievoMpDetail2
{
    public int Id { get; set; }

    public int AIdContatto { get; set; }

    public int IdComm { get; set; }

    public int AIdStag { get; set; }

    public int NrScheda { get; set; }

    public int IdRigaBp { get; set; }

    public string ATipo { get; set; } = null!;

    public string ACdAll { get; set; } = null!;

    public string ACdAllcol { get; set; } = null!;

    public string ACdAllmis { get; set; } = null!;

    public string ALotto { get; set; } = null!;

    public int IdFase { get; set; }

    public string BTipo { get; set; } = null!;

    public string BCdAll { get; set; } = null!;

    public string BCdAllcol { get; set; } = null!;

    public string BCdAllmis { get; set; } = null!;

    public string BLotto { get; set; } = null!;

    public bool BCkMatMis { get; set; }

    public decimal? Qta { get; set; }

    public decimal? QtaLorda { get; set; }

    public int? CapiFabbNetto { get; set; }

    public DateTime? DataEvaso { get; set; }

    public double? Cons { get; set; }

    public int? IdOrdMp { get; set; }

    public double? QtOrd { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }
}

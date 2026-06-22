using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzBuonoPrelievoMpDetail2
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

    public string? AParte { get; set; }

    public string? AParteDesc { get; set; }

    public string? AParteCol { get; set; }

    public string? AParteColDesc { get; set; }

    public string? AParteMis { get; set; }

    public string BTipo { get; set; } = null!;

    public string BCdAll { get; set; } = null!;

    public string BCdAllcol { get; set; } = null!;

    public string BCdAllmis { get; set; } = null!;

    public string BLotto { get; set; } = null!;

    public bool BCkMatMis { get; set; }

    public string? BParte { get; set; }

    public string? BParteDesc { get; set; }

    public string? BParteCol { get; set; }

    public string? BParteColDesc { get; set; }

    public string? BParteMis { get; set; }

    public string? BUm { get; set; }

    public string? BTp { get; set; }

    public decimal? Qta { get; set; }

    public int? CapiFabbNetto { get; set; }

    public int IdFase { get; set; }

    public DateTime? DataEvaso { get; set; }

    public decimal? QtaLorda { get; set; }

    public double? Cons { get; set; }

    public int? IdOrdMp { get; set; }

    public double? QtOrd { get; set; }

    public string? FaseCod { get; set; }

    public string? FaseDesc { get; set; }

    public bool? CkInvLogistica { get; set; }

    public bool? CkEvasoLogistica { get; set; }

    public string? CdMag { get; set; }

    public string? Nota { get; set; }

    public string? Stato { get; set; }

    public int? Hutile { get; set; }

    public int? CkMatMis { get; set; }
}

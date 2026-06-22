using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzBuonoPrelievoMp2Detail
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int NrScheda { get; set; }

    public string? NrPezza { get; set; }

    public double? FabbNetto { get; set; }

    public int? CapiFabbNetto { get; set; }

    public bool? CkInvLogistica { get; set; }

    public bool? CkEvasoLogistica { get; set; }

    public DateTime? DataEvaso { get; set; }

    public double? QtaLorda { get; set; }

    public string? Nota { get; set; }

    public int? Seq { get; set; }

    public double? Cons { get; set; }

    public int IdSetTg { get; set; }

    public int IdTg { get; set; }

    public bool? CkMatMis { get; set; }

    public string Lotto { get; set; } = null!;

    public string? MagLogico { get; set; }

    public string? CdMag { get; set; }

    public DateTime Ts { get; set; }

    public string? Tg { get; set; }

    public short? Hutile { get; set; }

    public int? IdTesta { get; set; }

    public string Stato { get; set; } = null!;

    public int? NrBuono { get; set; }

    public int? IdComm { get; set; }

    public int IdFase { get; set; }

    public string? FaseCod { get; set; }

    public string? FaseDesc { get; set; }

    public string? ModTess { get; set; }
}

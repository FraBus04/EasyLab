using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzBuonoPrelievoMpCkdiBa
{
    public int Id { get; set; }

    public int? CkDatodiBp { get; set; }

    public int IdContatto { get; set; }

    public int IdComm { get; set; }

    public int IdStag { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public string Lotto { get; set; } = null!;

    public string? NrPezza { get; set; }

    public double Qta { get; set; }

    public double? QtaProvv { get; set; }

    public double? QtaMov { get; set; }

    public int? IdBuono { get; set; }

    public int? NrScheda { get; set; }

    public string? CdMat { get; set; }

    public string? CodCol { get; set; }

    public string? Mis { get; set; }

    public string? MagLogico { get; set; }

    public string? CdMag { get; set; }

    public bool? CkInvLogistica { get; set; }

    public bool? CkEvasoLogistica { get; set; }

    public double? QtaLorda { get; set; }

    public string? Nota { get; set; }

    public short? Hutile { get; set; }

    public string? Stato { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? IdTgOrd { get; set; }

    public double? Cons { get; set; }

    public bool? CkMatMis { get; set; }

    public int? IdRigaBomDetail { get; set; }

    public int? CapiFabbNetto { get; set; }

    public double? FabbNetto { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public bool? CkMatGiaBp { get; set; }
}

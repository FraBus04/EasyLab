using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzBuonoPrelievoMp
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public int IdContatto { get; set; }

    public int IdComm { get; set; }

    public int IdStag { get; set; }

    public int IdFase { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public string Lotto { get; set; } = null!;

    public string NrPezza { get; set; } = null!;

    public decimal Qta { get; set; }

    public decimal? QtaLorda { get; set; }

    public decimal? QtaProvv { get; set; }

    public decimal? QtaMov { get; set; }

    public decimal QtaEvaso { get; set; }

    public decimal? ValEvaso { get; set; }

    public decimal? ValScr { get; set; }

    public decimal? ValSaldo { get; set; }

    public int? IdBuono { get; set; }

    public int? IdOrdMp { get; set; }

    public int NrScheda { get; set; }

    public string CdMat { get; set; } = null!;

    public string CodCol { get; set; } = null!;

    public string Mis { get; set; } = null!;

    public string? MagLogico { get; set; }

    public string? CdMag { get; set; }

    public bool? CkInvLogistica { get; set; }

    public bool? CkEvasoLogistica { get; set; }

    public string? Nota { get; set; }

    public short? Hutile { get; set; }

    public string Stato { get; set; } = null!;

    public int? NrBuono { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }

    public DateOnly? DataEvaso { get; set; }

    public int? CkPianif { get; set; }

    public bool? CkSfrido { get; set; }

    public double? Sfrido { get; set; }

    public int? IdTipoMat { get; set; }

    public string? Um { get; set; }

    public decimal? QtOrd { get; set; }

    public int? IdAllsku { get; set; }

    public string? ACdAll { get; set; }

    public string? BCdAll { get; set; }

    public string? BCdAllcol { get; set; }

    public string? BCdAllmis { get; set; }

    public string? CdEan { get; set; }

    public int IdEanpr { get; set; }
}

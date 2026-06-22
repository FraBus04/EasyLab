using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzBuonoPrelievoMpTempDoc
{
    public int Id { get; set; }

    public int IdDoc { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int IdComm { get; set; }

    public int IdMod { get; set; }

    public int? IdTipoMat { get; set; }

    public int IdBpriga { get; set; }

    public int IdFase { get; set; }

    public string? ACdAll { get; set; }

    public string? BTipo { get; set; }

    public string? BCdAll { get; set; }

    public string? BCdAllcol { get; set; }

    public string? BCdAllmis { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public int IdMpscar { get; set; }

    public string Lotto { get; set; } = null!;

    public string? StatoBpprovv { get; set; }

    public string? StatoBp { get; set; }

    public string? Um { get; set; }

    public double Qta { get; set; }

    public double? QtaLorda { get; set; }

    public double? QtaEvaso { get; set; }

    public double? QtaDaEvadere { get; set; }

    public double? QtaMov { get; set; }

    public double? QtaDoc { get; set; }

    public string? MagLogico { get; set; }

    public string? CdMag { get; set; }

    public bool? CkInvLogistica { get; set; }

    public bool? CkEvasoLogistica { get; set; }

    public double? QtaDaScar { get; set; }

    public double? MagDisp { get; set; }

    public int? IdUte { get; set; }

    public string? Tipo { get; set; }

    public int? IdForn { get; set; }

    public double? OrdDaEvadere { get; set; }

    public DateOnly? DataArrivoOrdini { get; set; }

    public DateOnly? PrimaDataPrevOrd { get; set; }

    public int? IdOrdPrimaDataPrev { get; set; }

    public int? CkPrimaDataPrevOrd { get; set; }

    public double? QtaDaEvadereNetta { get; set; }

    public string? CdAll { get; set; }

    public string? CdAllcol { get; set; }

    public string? CdAllmis { get; set; }

    public string? CdAllean { get; set; }

    public string? Modo { get; set; }
}

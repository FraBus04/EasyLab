using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzBuonoPrelievoMpTempDoc
{
    public int Id { get; set; }

    public int? NrComm { get; set; }

    public int IdFase { get; set; }

    public string? FaseCod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public int IdMat { get; set; }

    public string? Mat { get; set; }

    public string? DescMat { get; set; }

    public int? IdFornMat { get; set; }

    public string? FornMat { get; set; }

    public int IdMatCol { get; set; }

    public string? MatCol { get; set; }

    public string? MatColDesc { get; set; }

    public int IdMatMis { get; set; }

    public int IdMpscar { get; set; }

    public string? Mpscar { get; set; }

    public string Lotto { get; set; } = null!;

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

    public string? StatoBpprovv { get; set; }

    public int IdDoc { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int IdComm { get; set; }

    public int IdMod { get; set; }

    public int? IdTipoMat { get; set; }

    public string? CdTipoMat { get; set; }

    public string? OrdTipo { get; set; }

    public string? LabComm { get; set; }

    public int IdBpriga { get; set; }

    public string? MatMis { get; set; }

    public string? MatMisDesc { get; set; }

    public decimal? MagLordo { get; set; }

    public decimal? BuoniDaEvadere { get; set; }

    public double? FabbNetto { get; set; }

    public decimal? MagNetto { get; set; }

    public double? QtaDaScar { get; set; }

    public double? MagDisp { get; set; }

    public int? IdUte { get; set; }

    public string? Tipo { get; set; }

    public int? IdForn { get; set; }

    public string? StatoBp { get; set; }

    public string? Nota { get; set; }

    public double? OrdDaEvadere { get; set; }

    public DateOnly? DataArrivoOrdini { get; set; }

    public DateOnly? PrimaDataPrevOrd { get; set; }

    public int? IdOrdPrimaDataPrev { get; set; }

    public int? CkPrimaDataPrevOrd { get; set; }

    public double? QtaDaEvadereNetta { get; set; }

    public string? Parte { get; set; }

    public string? ParteDesc { get; set; }

    public string? CdAll { get; set; }

    public string? CdAllcol { get; set; }

    public string? CdAllmis { get; set; }

    public string? ParteCol { get; set; }

    public string? ParteColDesc { get; set; }

    public string? ParteMis { get; set; }

    public string? Modo { get; set; }

    public string? ACdAll { get; set; }

    public string? BTipo { get; set; }
}

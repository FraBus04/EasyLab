using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzBuonoPrelievoMp2
{
    public int Id { get; set; }

    public int IdComm { get; set; }

    public string? Tipocomm { get; set; }

    public string? CbAllcomm { get; set; }

    public string? ContattoComm { get; set; }

    public string? ParteComm { get; set; }

    public string? ParteDescComm { get; set; }

    public string? StagComm { get; set; }

    public int? NrComm { get; set; }

    public string? OrdTipoComm { get; set; }

    public string? SaldoComm { get; set; }

    public int? TotCapiComm { get; set; }

    public double? TotQtaComm { get; set; }

    public string? CdMagComm { get; set; }

    public int IdFase { get; set; }

    public string? FaseCod { get; set; }

    public string? FaseDesc { get; set; }

    public string? Tipo { get; set; }

    public string? Contatto { get; set; }

    public string? Parte { get; set; }

    public string? ParteDesc { get; set; }

    public string? Um { get; set; }

    public string? Tp { get; set; }

    public string? TpDesc { get; set; }

    public int? TpOrdPm { get; set; }

    public string? CdTipoMat { get; set; }

    public string? TipoMatDesc { get; set; }

    public int? TipoMatOrdPm { get; set; }

    public short? Hutile { get; set; }

    public string? Nota { get; set; }

    public string? CdMag { get; set; }

    public string Stato { get; set; } = null!;

    public decimal Qta { get; set; }

    public decimal? QtaLorda { get; set; }

    public decimal QtaEvaso { get; set; }

    public bool? CkInvLogistica { get; set; }

    public int? NrBuono { get; set; }

    public DateOnly? DataEvaso { get; set; }

    public string? BCdAll { get; set; }

    public string? BCdAllcol { get; set; }

    public string? BCdAllmis { get; set; }

    public string? CdEan { get; set; }

    public string? ParteCol { get; set; }

    public string? ParteColDesc { get; set; }

    public string? ParteMis { get; set; }

    public string? ParteMisDesc { get; set; }
}

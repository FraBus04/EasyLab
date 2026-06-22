using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBiCalcoloCostiCommesse
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public int IdStag { get; set; }

    public string? Stag { get; set; }

    public int IdComm { get; set; }

    public int IdMod { get; set; }

    public string MatLav { get; set; } = null!;

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public double QtaNetta { get; set; }

    public double QtaLorda { get; set; }

    public int? TotCapiMod { get; set; }

    public int? TotCapiModCol { get; set; }

    public double? Pz { get; set; }

    public double? TotValNetto { get; set; }

    public double? TotValLordo { get; set; }

    public int? IdLab { get; set; }

    public int? IdFase { get; set; }

    public string? Nota { get; set; }

    public int? NrComm { get; set; }

    public DateTime? DataComm { get; set; }

    public string? OrdTipo { get; set; }

    public string? Modello { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? Mat { get; set; }

    public string? DescMat { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public string? Misura { get; set; }

    public string? DescMis { get; set; }

    public string? Lab { get; set; }

    public string? FasiCod { get; set; }

    public string? FasiDesc { get; set; }

    public string? Tp { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? IdTipoList { get; set; }

    public string? CdTipoListino { get; set; }

    public string? TipoListino { get; set; }

    public decimal? List { get; set; }
}

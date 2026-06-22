using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VPianifLanciAssegnaz
{
    public int Id { get; set; }

    public int? IdTesta { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public int IdRiga { get; set; }

    public int IdMod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? PathImgMod { get; set; }

    public int? IdLabPrev { get; set; }

    public string? Lab { get; set; }

    public int IdModCol { get; set; }

    public string? ModColCod { get; set; }

    public string? ModColDesc { get; set; }

    public int IdMat { get; set; }

    public string? Mat { get; set; }

    public string? DescMat { get; set; }

    public string Tipo { get; set; } = null!;

    public string? Forn { get; set; }

    public string? CodArtFornitore { get; set; }

    public int IdMatCol { get; set; }

    public string? MatColCod { get; set; }

    public string? MatColDesc { get; set; }

    public string? MatColForn { get; set; }

    public int IdMatMis { get; set; }

    public string? MatMisCod { get; set; }

    public string? MatMisDesc { get; set; }

    public string? Um { get; set; }

    public double Qta { get; set; }

    public DateOnly? DataDisp { get; set; }

    public int CkMat { get; set; }

    public int CkDataOrd { get; set; }
}

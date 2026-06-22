using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VMovimentiMp
{
    public int Id { get; set; }

    public int IdTesta { get; set; }

    public string StatoTesta { get; set; } = null!;

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public int? IdForn { get; set; }

    public string? Anag1 { get; set; }

    public string? Anag2 { get; set; }

    public string? Via { get; set; }

    public string? CapNew { get; set; }

    public string? Citta { get; set; }

    public string NrDdt { get; set; } = null!;

    public string DataDdt { get; set; } = null!;

    public DateOnly? DataMov { get; set; }

    public int IdTipoMov { get; set; }

    public string? MovCod { get; set; }

    public string? MovDesc { get; set; }

    public string? NotaTesta { get; set; }

    public int IdCausale { get; set; }

    public string CdMag { get; set; } = null!;

    public string? Mat { get; set; }

    public string? DescMat { get; set; }

    public string? CodArtFornitore { get; set; }

    public string? Um { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public string MatMis { get; set; } = null!;

    public string? DescMis { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public string? CodColForn { get; set; }

    public string Lotto { get; set; } = null!;

    public string NrPezza { get; set; } = null!;

    public string? RifPezzaForn { get; set; }

    public int? IdStag { get; set; }

    public string? StagCod { get; set; }

    public string CdValuta { get; set; } = null!;

    public double? Pz { get; set; }

    public decimal Qta { get; set; }

    public decimal QtaLorda { get; set; }

    public decimal QtaBonif { get; set; }

    public decimal? QtaDisp { get; set; }

    public int? IdOrdRiga { get; set; }

    public int? IdOrd { get; set; }

    public DateTime DataIns { get; set; }

    public int? Hutile { get; set; }

    public string? Nota { get; set; }

    public int? IdMpscar { get; set; }

    public int? IdBp { get; set; }

    public int? IdBpriga { get; set; }

    public string? Tp { get; set; }

    public string? Tpdesc { get; set; }

    public int? IdTipoMat { get; set; }

    public string? CdTipoMat { get; set; }

    public string? TipoMatDesc { get; set; }

    public double? PzMat { get; set; }

    public int? IdMovCar { get; set; }

    public int? IdComm { get; set; }

    public int? Comm { get; set; }

    public string Stato { get; set; } = null!;

    public int? IdDoc { get; set; }

    public string? NrDoc { get; set; }

    public DateOnly? DataDoc { get; set; }

    public string? TipoDoc { get; set; }

    public string? TipoDocDesc { get; set; }

    public string? OrdLinea { get; set; }

    public int? IdLinea { get; set; }

    public string? Linea { get; set; }

    public string? CommBrand { get; set; }

    public int? IdFornMat { get; set; }

    public string? FornMat { get; set; }

    public string? NrOrd { get; set; }

    public bool? Lock { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VMagazzinoMpDetail
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public int? IdMpscar { get; set; }

    public string? CdMat { get; set; }

    public string Lotto { get; set; } = null!;

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public string? Mis { get; set; }

    public string? DescMis { get; set; }

    public string NrPezza { get; set; } = null!;

    public DateTime? DataIng { get; set; }

    public decimal? Qta { get; set; }

    public string? Scaffale { get; set; }

    public string? Posizione { get; set; }

    public string? Piano { get; set; }

    public string? MagLogico { get; set; }

    public string CdMag { get; set; } = null!;

    public string? CdCella { get; set; }

    public bool? Bloccato { get; set; }

    public bool? Disponibile { get; set; }

    public string? DescMat { get; set; }

    public string? Forn { get; set; }

    public string? CodArtFornitore { get; set; }

    public string? CodColForn { get; set; }

    public string? PathImgMat { get; set; }

    public string? PathImgCol { get; set; }

    public int? IdFornitore { get; set; }

    public double? Pz { get; set; }

    public DateOnly? DataCarico { get; set; }

    public int? IdDdt { get; set; }

    public int? IdOrd { get; set; }

    public int? IdStag { get; set; }

    public int? PesoMtqreale { get; set; }

    public int? Hutile { get; set; }

    public double? Difet1 { get; set; }

    public double? Difet2 { get; set; }

    public double? Difet3 { get; set; }

    public double? Difet4 { get; set; }

    public decimal? QtaDichiarata { get; set; }

    public decimal? QtaMisurata { get; set; }

    public string? Nota { get; set; }

    public string? Stag { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public string? Um { get; set; }

    public short? PesoMtqsk { get; set; }

    public short? HutileSk { get; set; }

    public string? CdTipoMat { get; set; }

    public string? NotaSk { get; set; }

    public decimal? QtaBonificoDichiarata { get; set; }

    public int? IdMovMp { get; set; }

    public int? IdMovMptesta { get; set; }

    public int? IdOrdRiga { get; set; }

    public int? IdOrdTesta { get; set; }

    public string? RifPezzaForn { get; set; }

    public bool? Saldato { get; set; }

    public string? NrPezzaMadre { get; set; }

    public string? CdMagDesc { get; set; }

    public int? IdTipoMat { get; set; }

    public int? RitX { get; set; }

    public int? RitY { get; set; }

    public int? IdTrattamento { get; set; }

    public string? Trattamento { get; set; }
}

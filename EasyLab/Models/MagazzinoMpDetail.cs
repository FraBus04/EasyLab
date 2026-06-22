using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MagazzinoMpDetail
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public string Lotto { get; set; } = null!;

    public string NrPezza { get; set; } = null!;

    public string CdMag { get; set; } = null!;

    public string? CdMat { get; set; }

    public string? CodCol { get; set; }

    public string? Mis { get; set; }

    public int? IdStag { get; set; }

    public int? IdMovMp { get; set; }

    public int? IdDdt { get; set; }

    public int? IdOrd { get; set; }

    public int? IdOrdRiga { get; set; }

    public decimal? Qta { get; set; }

    public decimal? QtaDichiarata { get; set; }

    public decimal? QtaMisurata { get; set; }

    public decimal? QtaBonificoDichiarata { get; set; }

    public string? Scaffale { get; set; }

    public string? Posizione { get; set; }

    public string? Piano { get; set; }

    public string? MagLogico { get; set; }

    public string? CdCella { get; set; }

    public bool? Bloccato { get; set; }

    public bool? Disponibile { get; set; }

    public string? Gest { get; set; }

    public int? PesoMtqreale { get; set; }

    public int? Hutile { get; set; }

    public double? Difet1 { get; set; }

    public double? Difet2 { get; set; }

    public double? Difet3 { get; set; }

    public double? Difet4 { get; set; }

    public string? Nota { get; set; }

    public string? RifPezzaForn { get; set; }

    public bool? Saldato { get; set; }

    public int? IdRigaMovCar { get; set; }

    public DateOnly? DataCarico { get; set; }

    public DateTime? DataIng { get; set; }

    public DateTime? Ts { get; set; }

    public string? NrPezzaMadre { get; set; }

    public int? RitX { get; set; }

    public int? RitY { get; set; }

    public int? IdTrattamento { get; set; }

    public string? CdAll { get; set; }

    public string? CdAllcol { get; set; }

    public string? CdAllmis { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MovimentiMp
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdContatto { get; set; }

    public int IdCausale { get; set; }

    public int IdTipoMov { get; set; }

    public string CdMag { get; set; } = null!;

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public string Lotto { get; set; } = null!;

    public string NrPezza { get; set; } = null!;

    public int IdTesta { get; set; }

    public int? IdStag { get; set; }

    public int? IdComm { get; set; }

    public int? IdDoc { get; set; }

    public int? IdDocRiga { get; set; }

    public int? IdOrd { get; set; }

    public int? IdOrdRiga { get; set; }

    public int? IdForn { get; set; }

    public int? IdBp { get; set; }

    public int? IdBpriga { get; set; }

    public int? IdMagazzinoMpDetail { get; set; }

    public int? IdMpscar { get; set; }

    public int? IdMovCar { get; set; }

    public string? RifPezzaForn { get; set; }

    public int? Hutile { get; set; }

    public int? IdDdtriga { get; set; }

    public string CdValuta { get; set; } = null!;

    public double? Pz { get; set; }

    public decimal Qta { get; set; }

    public decimal QtaLorda { get; set; }

    public decimal QtaBonif { get; set; }

    public decimal? QtaDisp { get; set; }

    public string? Nota { get; set; }

    public DateOnly? DataMov { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }

    public int? IdLinea { get; set; }

    public string? CdAll { get; set; }

    public string? CdAllcol { get; set; }

    public string? CdAllmis { get; set; }

    public bool? Lock { get; set; }

    public DateTime? DataLock { get; set; }

    public int? IdUteLock { get; set; }
}

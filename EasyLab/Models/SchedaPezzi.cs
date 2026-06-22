using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SchedaPezzi
{
    public int Id { get; set; }

    public int IdMod { get; set; }

    public string? Pezzo { get; set; }

    public int? OrdPm { get; set; }

    public string Cod { get; set; } = null!;

    public string? Descr { get; set; }

    public string? Mat { get; set; }

    public int? NrMat { get; set; }

    public int? Qt { get; set; }

    public int? Coppia { get; set; }

    public int? TotPzPiazz { get; set; }

    public bool? CkCosto { get; set; }

    public string? Opposto { get; set; }

    public string? Rotazione { get; set; }

    public double? Area { get; set; }

    public double? Perimetro { get; set; }

    public string? PathFile { get; set; }

    /// <summary>
    /// APPROVATA
    /// CONTABILIZZATA
    /// </summary>
    public string? Stato { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public byte[]? Immagine { get; set; }

    public string? Warning { get; set; }
}

using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class CommModFasi1
{
    public int Id { get; set; }

    public int? IdComm { get; set; }

    public string? CdAll { get; set; }

    public int? IdFase { get; set; }

    public string? Fase { get; set; }

    public string? Nota { get; set; }

    public int? OrdPm { get; set; }

    public double? Prz { get; set; }

    public int? TotCar { get; set; }

    public int? TotScr { get; set; }

    public int? TotDiff { get; set; }

    public short? CkOpen { get; set; }

    public bool? CkInBol { get; set; }

    public string? Forn { get; set; }

    public double? Tempo { get; set; }

    public double? TraspGg { get; set; }

    public int? IdUte { get; set; }

    public int? IdForn { get; set; }

    public int? IdContatto { get; set; }

    public double? PercFase { get; set; }

    public DateOnly? DataConfRientro { get; set; }

    public int? CkConfRientro { get; set; }

    public int? IdRiga { get; set; }
}

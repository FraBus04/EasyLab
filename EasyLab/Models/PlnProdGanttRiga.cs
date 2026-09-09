using System;

namespace EasyLab.Models;

public partial class PlnProdGanttRiga
{
    public int Id { get; set; }

    public string? Livello { get; set; }

    public int? IdParent { get; set; }

    public int? IdContatto { get; set; }

    public int? IdComm { get; set; }

    public int? IdMod { get; set; }

    public string? ACdAll { get; set; }

    public int? IdFase { get; set; }

    public string? Descr { get; set; }

    public DateOnly? DateDaDes { get; set; }

    public DateOnly? DateADes { get; set; }

    public double? Progress { get; set; }

    public DateOnly? DateCommercMin { get; set; }

    public DateOnly? DateCommercMax { get; set; }

    public string? DateCommercAll { get; set; }

    public int? TotCar { get; set; }

    public int? TotScar { get; set; }

    public bool? CkSaldo { get; set; }

    public double? PercTotCapiFin { get; set; }

    public DateOnly? DataConfRientro { get; set; }

    public bool? CkConfRientro { get; set; }

    public int? TortaAvanzFasi { get; set; }
}

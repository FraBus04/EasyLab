using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class PlnprodGantt
{
    public int Id { get; set; }

    public int? IdTesta { get; set; }

    public int? IdComm { get; set; }

    public int? IdMod { get; set; }

    public string? ACdAll { get; set; }

    public string? Livello { get; set; }

    public int? IdFase { get; set; }

    public int? IdParent { get; set; }

    public int? IdPredec { get; set; }

    public int? IdAvanzMod { get; set; }

    public string? Descr { get; set; }

    public DateOnly? DateDaDes { get; set; }

    public DateOnly? DateAdes { get; set; }

    public DateOnly? DateDaEff { get; set; }

    public DateOnly? DateAeff { get; set; }

    public int? ColoreFase1 { get; set; }

    public int? ColoreFase2 { get; set; }

    public byte[]? ImgMod1 { get; set; }

    public string? Nota { get; set; }

    public double? Progress { get; set; }

    public int? IdContatto { get; set; }

    public string? ColoreGant { get; set; }

    public int? OrdPm { get; set; }

    public int? IdCollAvanz { get; set; }

    public DateOnly? DateCommercMin { get; set; }

    public DateOnly? DateCommercMax { get; set; }

    public int? TotCapi { get; set; }

    public int? TotCar { get; set; }

    public int? TotScar { get; set; }

    public string? Saldo { get; set; }

    public DateOnly? DataConfRientro { get; set; }

    public int? CkConfRientro { get; set; }
}

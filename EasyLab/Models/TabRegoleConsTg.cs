using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabRegoleConsTg
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public string Cod { get; set; } = null!;

    public string? Descr { get; set; }

    public string? Regola { get; set; }

    public string CdParti { get; set; } = null!;

    public int? IdSet { get; set; }

    public int? IdSetTgBase { get; set; }

    public double Mis1 { get; set; }

    public double Mis2 { get; set; }

    public double Mis3 { get; set; }

    public double Mis4 { get; set; }

    public double Mis5 { get; set; }

    public double Mis6 { get; set; }

    public double Mis7 { get; set; }

    public double Mis8 { get; set; }

    public double Mis9 { get; set; }

    public double Mis10 { get; set; }

    public double Mis11 { get; set; }

    public double Mis12 { get; set; }

    public double Mis13 { get; set; }

    public double Mis14 { get; set; }

    public double Mis15 { get; set; }

    public double Mis16 { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

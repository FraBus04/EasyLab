using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class PezziModello
{
    public int Id { get; set; }

    public int IdModello { get; set; }

    public int IdMateriale { get; set; }

    public int IdTipoPezzo { get; set; }

    public string? Descr { get; set; }

    public int OrdPm { get; set; }

    public int? NrPezzi { get; set; }
}

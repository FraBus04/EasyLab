using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MovimentoRe
{
    public int Id { get; set; }

    public int IdTesta { get; set; }

    public int IdEan { get; set; }

    public string Ean { get; set; } = null!;

    public int IdCausale { get; set; }

    public int IdMov { get; set; }

    public string CodMag { get; set; } = null!;

    public bool Ck { get; set; }

    public string Nota { get; set; } = null!;

    public int Qt { get; set; }

    public double Pz { get; set; }

    public double Sconto { get; set; }

    public double Tot { get; set; }

    public DateTime DataUpd { get; set; }
}

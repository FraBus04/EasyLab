using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MovimentoRetestum
{
    public int Id { get; set; }

    public int IdRetail { get; set; }

    public int IdUte { get; set; }

    public DateTime DataMov { get; set; }

    public bool Ck { get; set; }

    public string Nota { get; set; } = null!;

    public int TotPezzi { get; set; }

    public double TotValNetto { get; set; }

    public double TotValSconto { get; set; }

    public int? IdCcli { get; set; }

    public bool? CkVenditaWeb { get; set; }
}

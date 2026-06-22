using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Clvpivot
{
    public int Id { get; set; }

    public int? IdContatto { get; set; }

    public string? IdStag { get; set; }

    public int IdComm { get; set; }

    public string? ATipo { get; set; }

    public string? CdAll { get; set; }

    public int? IdMod { get; set; }

    public int? IdFase { get; set; }

    public int? CkFaseEnab { get; set; }

    public int? CkFaseSaldo { get; set; }

    public int? IdDoc { get; set; }

    public int? IdCausale { get; set; }

    public int? QtaCar { get; set; }

    public int? QtaScar { get; set; }

    public int? QtaDiff { get; set; }

    public int? IdUte { get; set; }

    public DateTime DataIns { get; set; }
}

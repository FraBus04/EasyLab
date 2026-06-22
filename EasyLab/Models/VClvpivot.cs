using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VClvpivot
{
    public int Id { get; set; }

    public int? IdContatto { get; set; }

    public string? IdStag { get; set; }

    public int IdComm { get; set; }

    public string? ATipo { get; set; }

    public string? CdAll { get; set; }

    public int? IdFase { get; set; }

    public int? CkFaseEnab { get; set; }

    public int? CkFaseSaldo { get; set; }

    public int? IdDoc { get; set; }

    public int? IdCausale { get; set; }

    public int? NrScheda { get; set; }

    public string? OrdTipo { get; set; }

    public string? CommSaldo { get; set; }

    public int? CommTotCapi { get; set; }

    public int? CommTotCapiFin { get; set; }

    public double? CommPercTotCapiFin { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? FaseCod { get; set; }

    public string? FaseDesc { get; set; }

    public int? FaseOrdPm { get; set; }

    public int? QtaCar { get; set; }

    public int? QtaScar { get; set; }

    public int? QtaDiff { get; set; }

    public DateOnly? DataComm { get; set; }

    public DateTime? DataConfRientro { get; set; }

    public bool? CkConf { get; set; }
}

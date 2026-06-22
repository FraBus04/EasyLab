using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SintesiStatoOrdFasi
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int IdOrd { get; set; }

    public int IdFase { get; set; }

    public int? TotCapi { get; set; }

    public double? TotVal { get; set; }

    public string? Color { get; set; }

    public int? IdCcli { get; set; }

    public int? IdUte { get; set; }

    public double? PercCapi { get; set; }

    public double? PercVal { get; set; }

    public double? TotValVend { get; set; }

    public int? TotCapiVend { get; set; }

    public double? TotValMag { get; set; }

    public int? TotCapiMag { get; set; }

    public double? TotValSped { get; set; }

    public int? TotCapiSped { get; set; }

    public double? TotValDaAss { get; set; }

    public int? TotCapiDaAss { get; set; }

    public double? TotValAnn { get; set; }

    public int? TotCapiAnn { get; set; }

    public double? TotValVendPerc { get; set; }

    public double? TotValMagPerc { get; set; }

    public double? TotValSpedPerc { get; set; }

    public double? TotValDaAssPerc { get; set; }
}

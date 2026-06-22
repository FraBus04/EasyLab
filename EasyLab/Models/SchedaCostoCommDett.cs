using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SchedaCostoCommDett
{
    public int Id { get; set; }

    public int IdComm { get; set; }

    public int IdMod { get; set; }

    public string MatLav { get; set; } = null!;

    public short? OrdPm { get; set; }

    public string? MatOper { get; set; }

    public string Tp { get; set; } = null!;

    public decimal CostoUnit { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public decimal? ConsTot { get; set; }

    public decimal? ConsUnit { get; set; }

    public decimal? CostTot { get; set; }

    public decimal? CostUnit { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}

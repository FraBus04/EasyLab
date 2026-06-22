using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class StoreProposte
{
    public int Id { get; set; }

    public int IdLista { get; set; }

    public string CdMag { get; set; } = null!;

    public int IdModColNoStag { get; set; }

    public int IdSetOrd { get; set; }

    public int? IdEan { get; set; }

    public int? IdStag { get; set; }

    public int? IdModCol { get; set; }

    public DateOnly? StagDa { get; set; }

    public DateOnly? StagA { get; set; }

    public int? SellStagSku { get; set; }

    public int? SellStagModCol { get; set; }

    public int? SellStagModColAllStore { get; set; }

    public int? SellPeriodoSku { get; set; }

    public int? SellPeriodoModCol { get; set; }

    public double? PercSellStagModCol { get; set; }

    public double? PercSellStagSku { get; set; }

    public int? Stock { get; set; }

    public int? StockMin { get; set; }

    public int? StockT1 { get; set; }

    public int? StockT6 { get; set; }

    public int? StockT1t6 { get; set; }

    public int? Prop { get; set; }

    public DateTime? DateIns { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdSet { get; set; }
}

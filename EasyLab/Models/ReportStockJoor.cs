using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ReportStockJoor
{
    public int Id { get; set; }

    public string? StyleName { get; set; }

    public string? StyleNumber { get; set; }

    public string? ColorName { get; set; }

    public string? ColorCode { get; set; }

    public string? Size { get; set; }

    public string? SizeCode { get; set; }

    public int? Quantity { get; set; }

    public int? WarehouseId { get; set; }

    public string? Warehouse { get; set; }

    public DateTime? Date { get; set; }

    public int? IdModColNoStag { get; set; }

    public string? Mag { get; set; }

    public string? DataDaStr { get; set; }

    public string? DataAstr { get; set; }

    public int? Sell { get; set; }

    public string? Ean { get; set; }

    public int? IdLista { get; set; }
}

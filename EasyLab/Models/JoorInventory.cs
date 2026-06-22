using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class JoorInventory
{
    public string? StyleId { get; set; }

    public string? Linesheet { get; set; }

    public string? Season { get; set; }

    public string? StyleName { get; set; }

    public string? StyleNumber { get; set; }

    public string? ColorName { get; set; }

    public string? ColorCode { get; set; }

    public string? Size { get; set; }

    public string? SizeCode { get; set; }

    public string? Upc { get; set; }

    public string? Quantity { get; set; }

    public string? PendingOrders { get; set; }

    public string? ApprovedOrders { get; set; }

    public string? WarehouseId { get; set; }

    public string? Warehouse { get; set; }

    public string? Ref { get; set; }

    public string? Date { get; set; }

    public string? Ean { get; set; }
}

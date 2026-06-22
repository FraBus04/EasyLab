using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Temp1
{
    public double? Id { get; set; }

    public string? Name { get; set; }

    public string? Command { get; set; }

    public string? SendReceipt { get; set; }

    public string? InventoryBehaviour { get; set; }

    public byte? Number { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Note { get; set; }

    public string? Tags { get; set; }

    public string? TagsCommand { get; set; }

    public string? CreatedAt { get; set; }

    public string? UpdatedAt { get; set; }

    public string? CancelledAt { get; set; }

    public string? CancelReason { get; set; }

    public string? CancelSendReceipt { get; set; }

    public string? CancelRefund { get; set; }

    public string? ProcessedAt { get; set; }

    public string? ClosedAt { get; set; }

    public string? Currency { get; set; }

    public string? Source { get; set; }

    public string? SourceIdentifier { get; set; }

    public string? SourceUrl { get; set; }

    public string? PhysicalLocation { get; set; }

    public long? UserId { get; set; }

    public double? CheckoutId { get; set; }

    public string? CartToken { get; set; }

    public string? Token { get; set; }

    public string? OrderStatusUrl { get; set; }

    public double? WeightTotal { get; set; }

    public string? PriceTotalLineItems { get; set; }

    public string? PriceCurrentSubtotal { get; set; }

    public string? PriceSubtotal { get; set; }

    public string? Tax1Title { get; set; }

    public TimeOnly? Tax1Rate { get; set; }

    public string? Tax1Price { get; set; }

    public string? Tax2Title { get; set; }

    public string? Tax2Rate { get; set; }

    public string? Tax2Price { get; set; }

    public string? Tax3Title { get; set; }

    public string? Tax3Rate { get; set; }

    public string? Tax3Price { get; set; }
}

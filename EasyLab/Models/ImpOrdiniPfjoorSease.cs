using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpOrdiniPfjoorSease
{
    public string? JoorOrderId { get; set; }

    public string? JoorPoNumber { get; set; }

    public string? CustomerCode { get; set; }

    public string? Retailer { get; set; }

    public string? BillingCode { get; set; }

    public string? BillingName { get; set; }

    public string? BillingAddress1 { get; set; }

    public string? BillingAddress2 { get; set; }

    public string? BillingCity { get; set; }

    public string? BillingState { get; set; }

    public string? BillingZip { get; set; }

    public string? BillingCountry { get; set; }

    public string? ShippingCode { get; set; }

    public string? ShippingName { get; set; }

    public string? ShippingAddress1 { get; set; }

    public string? ShippingAddress2 { get; set; }

    public string? ShippingCity { get; set; }

    public string? ShippingZip { get; set; }

    public string? ShippingCountry { get; set; }

    public string? SalesRepCode { get; set; }

    public string? Currency { get; set; }

    public string? PriceType { get; set; }

    public string? LinesheetName { get; set; }

    public string? SeasonName { get; set; }

    public string? SeasonYear { get; set; }

    public string? StyleNumber { get; set; }

    public string? StyleName { get; set; }

    public string? ColorName { get; set; }

    public string? ColorCode { get; set; }

    public string? SizeName { get; set; }

    public string? Upc { get; set; }

    public int? Quantity { get; set; }

    public double? ItemPrice { get; set; }

    public int? TotalUnits { get; set; }

    public double? OrderTotal { get; set; }

    public string? DiscountPercent { get; set; }

    public string? ShippingStart { get; set; }

    public string? ShippingEnd { get; set; }

    public string? PaymentMethodCode { get; set; }

    public string? PaymentMethodName { get; set; }

    public string? ShippingMethodCode { get; set; }

    public string? ShippingMethodName { get; set; }

    public string? OrderCreated { get; set; }

    public string? OrderApproved { get; set; }

    public string? BuyerName { get; set; }

    public string? OrderComments { get; set; }

    public string? OrderType { get; set; }

    public string? Status { get; set; }
}

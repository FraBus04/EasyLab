using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Order
{
    public long? Id { get; set; }

    public string? Name { get; set; }

    public string? Command { get; set; }

    public string? SendReceipt { get; set; }

    public string? InventoryBehaviour { get; set; }

    public short? Number { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Note { get; set; }

    public string? Tags { get; set; }

    public string? TagsCommand { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CancelledAt { get; set; }

    public string? CancelReason { get; set; }

    public string? CancelSendReceipt { get; set; }

    public string? CancelRefund { get; set; }

    public DateTime? ProcessedAt { get; set; }

    public DateTime? ClosedAt { get; set; }

    public string? Currency { get; set; }

    public string? Source { get; set; }

    public string? SourceIdentifier { get; set; }

    public string? SourceUrl { get; set; }

    public string? PhysicalLocation { get; set; }

    public long? UserId { get; set; }

    public float? CheckoutId { get; set; }

    public string? CartToken { get; set; }

    public string? Token { get; set; }

    public string? OrderStatusUrl { get; set; }

    public float? WeightTotal { get; set; }

    public float? PriceTotalLineItems { get; set; }

    public float? PriceCurrentSubtotal { get; set; }

    public float? PriceSubtotal { get; set; }

    public string? Tax1Title { get; set; }

    public float? Tax1Rate { get; set; }

    public float? Tax1Price { get; set; }

    public string? Tax2Title { get; set; }

    public string? Tax2Rate { get; set; }

    public string? Tax2Price { get; set; }

    public string? Tax3Title { get; set; }

    public string? Tax3Rate { get; set; }

    public string? Tax3Price { get; set; }

    public string? TaxIncluded { get; set; }

    public float? TaxTotal { get; set; }

    public float? PriceTotalDiscount { get; set; }

    public float? PriceTotalShipping { get; set; }

    public string? PriceCurrentTotalDuties { get; set; }

    public string? PriceTotalDuties { get; set; }

    public string? PriceCurrentTotalFees { get; set; }

    public string? PriceTotalFees { get; set; }

    public float? PriceTotalRefund { get; set; }

    public float? PriceTotalOutstanding { get; set; }

    public float? PriceCurrentTotal { get; set; }

    public float? PriceTotal { get; set; }

    public string? PaymentStatus { get; set; }

    public string? OrderFulfillmentStatus { get; set; }

    public string? AdditionalDetails { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public float? CustomerId { get; set; }

    public string? CustomerEmail { get; set; }

    public string? CustomerPhone { get; set; }

    public string? CustomerFirstName { get; set; }

    public string? CustomerLastName { get; set; }

    public string? CustomerNote { get; set; }

    public string? CustomerState { get; set; }

    public string? CustomerTags { get; set; }

    public string? CustomerAcceptsMarketing { get; set; }

    public string? CustomerTaxExempt { get; set; }

    public short? CustomerOrdersCount { get; set; }

    public float? CustomerTotalSpent { get; set; }

    public string? BillingFirstName { get; set; }

    public string? BillingLastName { get; set; }

    public string? BillingName { get; set; }

    public string? BillingCompany { get; set; }

    public string? BillingPhone { get; set; }

    public string? BillingAddress1 { get; set; }

    public string? BillingAddress2 { get; set; }

    public string? BillingZip { get; set; }

    public string? BillingCity { get; set; }

    public string? BillingProvince { get; set; }

    public string? BillingProvinceCode { get; set; }

    public string? BillingCountry { get; set; }

    public string? BillingCountryCode { get; set; }

    public string? ShippingFirstName { get; set; }

    public string? ShippingLastName { get; set; }

    public string? ShippingName { get; set; }

    public string? ShippingCompany { get; set; }

    public string? ShippingPhone { get; set; }

    public string? ShippingAddress1 { get; set; }

    public string? ShippingAddress2 { get; set; }

    public string? ShippingZip { get; set; }

    public string? ShippingCity { get; set; }

    public string? ShippingProvince { get; set; }

    public string? ShippingProvinceCode { get; set; }

    public string? ShippingCountry { get; set; }

    public string? ShippingCountryCode { get; set; }

    public float? BrowserIp { get; set; }

    public string? BrowserWidth { get; set; }

    public string? BrowserHeight { get; set; }

    public string? BrowserUserAgent { get; set; }

    public string? BrowserLandingPage { get; set; }

    public string? BrowserReferrer { get; set; }

    public string? BrowserReferrerDomain { get; set; }

    public string? BrowserSearchKeywords { get; set; }

    public string? BrowserAdUrl { get; set; }

    public string? BrowserUtmSource { get; set; }

    public string? BrowserUtmMedium { get; set; }

    public string? BrowserUtmCampaign { get; set; }

    public string? BrowserUtmTerm { get; set; }

    public string? BrowserUtmContent { get; set; }

    public string? Row { get; set; }

    public DateTime? TopRow { get; set; }

    public string? LineType { get; set; }

    public string? LineId { get; set; }

    public string? LineCommand { get; set; }

    public string? LineProductId { get; set; }

    public string? LineProductHandle { get; set; }

    public string? LineTitle { get; set; }

    public string? LineName { get; set; }

    public string? LineVariantId { get; set; }

    public string? LineVariantTitle { get; set; }

    public string? LineSku { get; set; }

    public string? LineQuantity { get; set; }

    public string? LinePrice { get; set; }

    public string? LineDiscount { get; set; }

    public string? LineDiscountAllocation { get; set; }

    public string? LineDiscountPerItem { get; set; }

    public string? LineTotal { get; set; }

    public string? LineGrams { get; set; }

    public string? LineRequiresShipping { get; set; }

    public string? LineVendor { get; set; }

    public string? LineProperties { get; set; }

    public string? LineGiftCard { get; set; }

    public string? LineForceGiftCard { get; set; }

    public string? LineTaxable { get; set; }

    public string? LineTaxTotal { get; set; }

    public string? LineTax1Title { get; set; }

    public string? LineTax1Rate { get; set; }

    public float? LineTax1Price { get; set; }

    public string? LineTax2Title { get; set; }

    public string? LineTax2Rate { get; set; }

    public float? LineTax2Price { get; set; }

    public float? LineTax3Title { get; set; }

    public string? LineTax3Rate { get; set; }

    public float? LineTax3Price { get; set; }

    public float? LineFulfillableQuantity { get; set; }

    public string? LineFulfillmentService { get; set; }

    public string? LineFulfillmentStatus { get; set; }

    public string? LinePreTaxPrice { get; set; }

    public float? RefundId { get; set; }

    public DateTime? RefundCreatedAt { get; set; }

    public DateTime? RefundNote { get; set; }

    public DateTime? RefundRestock { get; set; }

    public string? RefundRestockType { get; set; }

    public string? RefundRestockLocation { get; set; }

    public string? RefundSendReceipt { get; set; }

    public string? RefundGenerateTransaction { get; set; }

    public long? TransactionId { get; set; }

    public long? TransactionKind { get; set; }

    public DateTime? TransactionProcessedAt { get; set; }

    public DateTime? TransactionAmount { get; set; }

    public string? TransactionCurrency { get; set; }

    public string? TransactionStatus { get; set; }

    public string? TransactionMessage { get; set; }

    public string? TransactionGateway { get; set; }

    public string? TransactionForceGateway { get; set; }

    public DateTime? TransactionTest { get; set; }

    public string? TransactionAuthorization { get; set; }

    public string? TransactionPaymentId { get; set; }

    public string? TransactionDeviceId { get; set; }

    public string? TransactionUserId { get; set; }

    public string? TransactionParentId { get; set; }

    public long? TransactionErrorCode { get; set; }

    public string? TransactionCcAvsResult { get; set; }

    public string? TransactionCcBin { get; set; }

    public string? TransactionCcCvvResult { get; set; }

    public int? TransactionCcNumber { get; set; }

    public string? TransactionCcCompany { get; set; }

    public string? RiskSource { get; set; }

    public string? RiskScore { get; set; }

    public string? RiskRecommendation { get; set; }

    public string? RiskCauseCancel { get; set; }

    public string? RiskMessage { get; set; }

    public string? FulfillmentId { get; set; }

    public string? FulfillmentStatus { get; set; }

    public DateTime? FulfillmentCreatedAt { get; set; }

    public DateTime? FulfillmentUpdatedAt { get; set; }

    public DateTime? FulfillmentTrackingCompany { get; set; }

    public DateTime? FulfillmentLocation { get; set; }

    public string? FulfillmentShipmentStatus { get; set; }

    public string? FulfillmentTrackingNumber { get; set; }

    public string? FulfillmentTrackingUrl { get; set; }

    public string? FulfillmentSendReceipt { get; set; }
}

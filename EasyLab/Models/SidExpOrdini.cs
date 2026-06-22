using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SidExpOrdini
{
    public int? JoorOrderId { get; set; }

    public int? JoorPoNumber { get; set; }

    public int? CustomerCode { get; set; }

    public string? Retailer { get; set; }

    public int? CustomerCode2 { get; set; }

    public string? Retailer2 { get; set; }

    public byte? BillingCode { get; set; }

    public string? BillingName { get; set; }

    public string? BillingAddress1 { get; set; }

    public string? BillingAddress2 { get; set; }

    public string? BillingCity { get; set; }

    public string? BillingState { get; set; }

    public string? BillingZip { get; set; }

    public string? BillingCountry { get; set; }

    public byte? ShippingCode { get; set; }

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

    public short? SeasonYear { get; set; }

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

    public int? DiscountPercent { get; set; }

    public DateOnly? ShippingStart { get; set; }

    public DateOnly? ShippingEnd { get; set; }

    public string? PaymentMethodCode { get; set; }

    public string? PaymentMethodName { get; set; }

    public string? ShippingMethodCode { get; set; }

    public string? ShippingMethodName { get; set; }

    public DateOnly? OrderCreated { get; set; }

    public DateOnly? OrderApproved { get; set; }

    public string? BuyerName { get; set; }

    public string? OrderComments { get; set; }

    public string? Po { get; set; }

    public int? IdOrd { get; set; }

    public int? IdRiga { get; set; }

    public string? SyncCoddoc { get; set; }

    public int? IdDoc { get; set; }

    public string? NrDoc { get; set; }

    public DateOnly? DataDoc { get; set; }

    public long? IdErpDoc { get; set; }

    public int? IdErpRiga { get; set; }

    public string? CausaleCod { get; set; }

    public string? TraspCuraCod { get; set; }

    public string? VettoreCod { get; set; }

    public string? ResaCod { get; set; }

    public string? CodMagBp { get; set; }

    public int? IdPriorita { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public string? CdValuta { get; set; }

    public int? OrdTg { get; set; }

    public string? SyncIdaltraproc { get; set; }

    public string? MagPrel { get; set; }

    public string? MagCarico { get; set; }

    public string? Ragg1OrdTesta { get; set; }

    public int? IdRagg1 { get; set; }

    public string? Modo { get; set; }

    public int? IdTipoDoc { get; set; }

    public int? IdRigaOrd { get; set; }

    public string? OrdTipo { get; set; }

    public string? CdMag1 { get; set; }

    public string? CdMag2 { get; set; }

    public int? IdTipoAnag { get; set; }

    public string? TipoDoc { get; set; }

    public string? NotaDoc { get; set; }

    public string? Nota { get; set; }

    public bool? SyncFlgtrasfint { get; set; }

    public DateOnly? DataConfRientro { get; set; }

    public int? NrComm { get; set; }

    public int? SyncNumdoc { get; set; }

    public int? SyncOrdineid { get; set; }

    public string? SyncCodval { get; set; }

    public string? SyncCoddep { get; set; }

    public string? SyncCoddepcol { get; set; }

    public int? SyncProgriga { get; set; }

    public int? SyncProgpadre { get; set; }

    public int Id { get; set; }

    public DateOnly? DataExp { get; set; }

    public int? SyncTipoclifor { get; set; }
}

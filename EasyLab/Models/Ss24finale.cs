using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Ss24finale
{
    public string? StyleNumber { get; set; }

    public string? StyleName { get; set; }

    public string? StyleComment { get; set; }

    public string? ColorName { get; set; }

    public string? ColorCode { get; set; }

    public string? Retailer { get; set; }

    public int? CustomerCode { get; set; }

    public string? Po { get; set; }

    public string? OrderType { get; set; }

    public string? Door { get; set; }

    public string? Shipping { get; set; }

    public string? Payment { get; set; }

    public string? PriceLabel { get; set; }

    public double? WholesalePrice { get; set; }

    public double? RetailPrice { get; set; }

    public double? OriginalExtWholesale { get; set; }

    public double? ExtendedWholesale { get; set; }

    public double? ExtendedRetail { get; set; }

    public double? OrderOrigExtWholesale { get; set; }

    public double? OrderExtendedWholesale { get; set; }

    public DateOnly? StartShip { get; set; }

    public DateOnly? CompleteShip { get; set; }

    public string? ShippingCountry { get; set; }

    public string? ShippingState { get; set; }

    public string? ShippingCity { get; set; }

    public string? BuyerEmail { get; set; }

    public string? Status { get; set; }

    public string? SalesRep { get; set; }

    public string? Gender { get; set; }

    public string? SeasonTag { get; set; }

    public string? Size { get; set; }

    public int? Units { get; set; }

    public int? IdStag { get; set; }

    public int? IdCcli { get; set; }

    public int? IdOrd { get; set; }

    public string? CdPag { get; set; }

    public int? IdPag { get; set; }

    public int? IdRagg1 { get; set; }

    public int? IdDdtResa { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public int? IdTgOrd { get; set; }

    public int? IdsetTaglia { get; set; }

    public int? IdTagliaOrd { get; set; }

    public int? IdSet { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdBarcode { get; set; }
}

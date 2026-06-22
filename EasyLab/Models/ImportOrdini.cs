using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImportOrdini
{
    public int Id { get; set; }

    public string? Overview { get; set; }

    public string? Image { get; set; }

    public string? Linesheet { get; set; }

    public string? Division { get; set; }

    public string? Category { get; set; }

    public string? Subcategory { get; set; }

    public string? StyleNumber { get; set; }

    public string? StyleName { get; set; }

    public string? ColorName { get; set; }

    public string? ColorCode { get; set; }

    public string? Material { get; set; }

    public string? Retailer { get; set; }

    public string? CustomerCode { get; set; }

    public string? Po { get; set; }

    public string? OrderType { get; set; }

    public string? Shipping { get; set; }

    public string? Payment { get; set; }

    public string? StartShip { get; set; }

    public string? CompleteShip { get; set; }

    public string? Door { get; set; }

    public string? ShippingCountry { get; set; }

    public string? ShippingCity { get; set; }

    public string? WarehouseCode { get; set; }

    public string? Warehouse { get; set; }

    public string? Measurements { get; set; }

    public string? FabricationCode { get; set; }

    public string? Fabrication { get; set; }

    public string? SilhouetteName { get; set; }

    public string? SilhouetteCode { get; set; }

    public string? CountryOfOrigin { get; set; }

    public string? PriceLabel { get; set; }

    public string? WholesalePrice { get; set; }

    public string? RetailPrice { get; set; }

    public string? OriginalExtWholesale { get; set; }

    public string? ExtendedWholesale { get; set; }

    public string? ExtendedRetail { get; set; }

    public string? Bulk { get; set; }

    public string? SM { get; set; }

    public string? LXl { get; set; }

    public string? Xs { get; set; }

    public string? Tgu { get; set; }

    public string? S { get; set; }

    public string? M { get; set; }

    public string? L { get; set; }

    public string? Xl { get; set; }

    public string? Xxl { get; set; }

    public string? _3xl { get; set; }

    public string? SubTotal { get; set; }

    public string? TotalUnits { get; set; }

    public string? SeasonTag { get; set; }

    public string? Colonna50 { get; set; }

    public int? IdMod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public int? Ccli { get; set; }

    public int? CcliDest { get; set; }

    public int? IdContatto { get; set; }

    public int? IdStag { get; set; }

    public int? NrOrd { get; set; }

    public DateTime? OrdData { get; set; }

    public DateTime? DataConsDa { get; set; }

    public DateTime? DataConsA { get; set; }

    public short? IdSetTaglie { get; set; }
}
